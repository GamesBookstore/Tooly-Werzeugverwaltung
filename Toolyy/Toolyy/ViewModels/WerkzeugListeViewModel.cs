using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Toolyy.Models;
using Common;
using Prism.Events;
using System.Windows.Input;
using Common.Command;
using Toolyy.View;

namespace Toolyy.ViewModels
{
    public class WerkzeugListeViewModel : BaseViewModel
    {
        public ObservableCollection<Werkzeug> Werkzeuge { get; set; }

        private Werkzeug _ausgewaehltesWerkzeug;
        public Werkzeug AusgewaehltesWerkzeug
        {
            get => _ausgewaehltesWerkzeug;
            set
            {
                _ausgewaehltesWerkzeug = value;
                OnPropertyChanged(nameof(AusgewaehltesWerkzeug));
                (BearbeitenCommand as ActionCommand)?.RaiseCanExecuteChanged();
                (LoeschenCommand as ActionCommand)?.RaiseCanExecuteChanged();

            }

        }

        public ICommand BearbeitenCommand { get; }
        public ICommand LoeschenCommand { get; }
        public ICommand HinzufuegenCommand { get; }
        public WerkzeugListeViewModel() : base(null)
        {
            Werkzeuge = new ObservableCollection<Werkzeug>

            {
                new Werkzeug(1, "Hammer", "Handwerkzeug", true, "Lager A"),
                new Werkzeug(2, "Bohrmaschine", "Elektro", false, "Lager B"),
                new Werkzeug(3, "Zange", "Handwerkzeug", true, "Werkstatt"),
                new Werkzeug(4, "Akkuschrauber", "Elektro", true, "Lager C")
            };

            BearbeitenCommand = new ActionCommand(Bearbeiten, CanBearbeitenOderLoeschen);
            LoeschenCommand = new ActionCommand(Loeschen, CanBearbeitenOderLoeschen);
            HinzufuegenCommand = new ActionCommand(Hinzufuegen, null);
        }

        //public WerkzeugListeViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        //{
        //}

        public ICommand WerkzeugAusgewaehltCommand { get; set; }

        private bool CanBearbeitenOderLoeschen(object parameter)
        {
            return AusgewaehltesWerkzeug != null;
        }

        private void Bearbeiten(object parameter)
        {
            if (AusgewaehltesWerkzeug == null)
            {
                return;
            }

            var dialog = new AddWerkzeugView(AusgewaehltesWerkzeug); 
            if (dialog.ShowDialog() == true)
            {                
                OnPropertyChanged(nameof(Werkzeuge));
            }
        }

        private void Loeschen(object parameter)
        {
            if (AusgewaehltesWerkzeug != null && MessageBox.Show($"Werkzeug „{AusgewaehltesWerkzeug.Name}“ wirklich löschen?","Löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Werkzeuge.Remove(AusgewaehltesWerkzeug);
                AusgewaehltesWerkzeug = null;
            }
        }

        private void Hinzufuegen(object parameter)
        {
            var neuesWerkzeug = new Werkzeug(); 
            var dialog = new AddWerkzeugView(neuesWerkzeug);

            if (dialog.ShowDialog() == true)
            {
                neuesWerkzeug.Id = Werkzeuge.Count + 1;
                Werkzeuge.Add(neuesWerkzeug);
            }
        }

        private void WerkzeugAusgewaehlt(object parameter)
        {
            if (AusgewaehltesWerkzeug == null)
            {
                return;
            }

            MessageBox.Show(
                $"Ausgewählt: {AusgewaehltesWerkzeug.Name}\n" +
                $"Kategorie: {AusgewaehltesWerkzeug.Category}\n" +
                $"Verfügbar: {(AusgewaehltesWerkzeug.Available ? "Ja" : "Nein")}",
                "Werkzeugdetails",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        private bool CanWerkzeugAusgewaehlt(object parameter)
        {
            return true;

        }


    }
}

