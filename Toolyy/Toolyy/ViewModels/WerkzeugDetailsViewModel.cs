using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Toolyy.Models;
using Toolyy.View;
using Common.Command;

namespace Toolyy.ViewModels
{
    public class WerkzeugDetailsViewModel : INotifyPropertyChanged
    {
        public Werkzeug Werkzeug { get; private set; }

        public ICommand AusborgenCommand { get; private set; }
        public ICommand RetournierenCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public WerkzeugDetailsViewModel(Werkzeug werkzeug)
        {
            Werkzeug = werkzeug;

            AusborgenCommand = new ActionCommand(AusborgenExecute, AusborgenCanExecute);
            RetournierenCommand = new ActionCommand(RetournierenExecute, RetournierenCanExecute);
        }

        private bool AusborgenCanExecute(object parameter)
        {
            return Werkzeug.Available;
        }

        private void AusborgenExecute(object parameter)
        {
            var dialog = new InputNameDialog(); 
            if (dialog.ShowDialog() == true)
            {
                Werkzeug.Available = false;
                Werkzeug.GeborgtVon = dialog.UserName;
                Werkzeug.GeborgtAm = DateTime.Now;
                NotifyAll();
            }
        }

        private bool RetournierenCanExecute(object parameter)
        {
            return !Werkzeug.Available;
        }

        private void RetournierenExecute(object parameter)
        {
            Werkzeug.Available = true;
            Werkzeug.GeborgtVon = null;
            Werkzeug.GeborgtAm = null;
            NotifyAll();
        }

        public string StatusText => Werkzeug.Available ? "Verfügbar" : "Ausgeborgt";

        public string VerliehenInfo =>
            !Werkzeug.Available
                ? $"Geborgt von {Werkzeug.GeborgtVon} am {Werkzeug.GeborgtAm?.ToString("g")}"
                : "";

        private void NotifyAll()
        {
            OnPropertyChanged(nameof(StatusText));
            OnPropertyChanged(nameof(VerliehenInfo));
        }

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
