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
                WerkzeugAusgewaehltCommand?.Execute(null);

            }


        }
        public WerkzeugListeViewModel() : base(null)
        {
            Werkzeuge = new ObservableCollection<Werkzeug>

            {
                new Werkzeug(1, "Hammer", "Handwerkzeug", true, "Lager A"),
                new Werkzeug(2, "Bohrmaschine", "Elektro", false, "Lager B"),
                new Werkzeug(3, "Zange", "Handwerkzeug", true, "Werkstatt"),
                new Werkzeug(4, "Akkuschrauber", "Elektro", true, "Lager C")
            };

            WerkzeugAusgewaehltCommand = new ActionCommand(WerkzeugAusgewaehlt, CanWerkzeugAusgewaehlt);

        }
        public ICommand WerkzeugAusgewaehltCommand { get; set; }

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

