using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Toolyy.Models;
using Common;
using Prism.Events;

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
                // Optional: Interaktion starten, z. B. Dialog öffnen
            }
        }

        public WerkzeugListeViewModel() : base(null)
        {
            // Statische Beispiel-Daten
            Werkzeuge = new ObservableCollection<Werkzeug>
            {
                new Werkzeug(1, "Hammer", "Handwerkzeug", true, "Lager A"),
                new Werkzeug(2, "Bohrmaschine", "Elektro", false, "Lager B"),
                new Werkzeug(3, "Zange", "Handwerkzeug", true, "Werkstatt"),
                new Werkzeug(4, "Akkuschrauber", "Elektro", true, "Lager C")
            };
        }
    }
}
