using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Common;
using Common.Command;
using Prism.Events;
using Toolyy.Models;
using Toolyy.View;
using Toolyy.Events;

namespace Toolyy.ViewModels
{
    public class WerkzeugListeViewModel : BaseViewModel
    {
        private readonly IEventAggregator _eventAggregator;

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

        public WerkzeugListeViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            _eventAggregator = eventAggregator;

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

            
            _eventAggregator.GetEvent<WerkzeugAddedEvent>().Subscribe(OnWerkzeugAdded, ThreadOption.UIThread);
        }

        private bool CanBearbeitenOderLoeschen(object parameter)
        {
            return AusgewaehltesWerkzeug != null;
        }

        private void Bearbeiten(object parameter)
        {
            if (AusgewaehltesWerkzeug == null) return;

            var tempWerkzeug = new Werkzeug
            {
                Id = AusgewaehltesWerkzeug.Id,
                Name = AusgewaehltesWerkzeug.Name,
                Category = AusgewaehltesWerkzeug.Category,
                Available = AusgewaehltesWerkzeug.Available,
                Location = AusgewaehltesWerkzeug.Location
            };

            var dialog = new EditWerkzeugView(tempWerkzeug, _eventAggregator); 
            if (dialog.ShowDialog() == true)
            {
                AusgewaehltesWerkzeug.Name = tempWerkzeug.Name;
                AusgewaehltesWerkzeug.Category = tempWerkzeug.Category;
                AusgewaehltesWerkzeug.Available = tempWerkzeug.Available;
                AusgewaehltesWerkzeug.Location = tempWerkzeug.Location;
                
                OnPropertyChanged(nameof(Werkzeuge)); 
            }
        }

        private void Loeschen(object parameter)
        {
            if (AusgewaehltesWerkzeug != null &&
                MessageBox.Show($"Werkzeug „{AusgewaehltesWerkzeug.Name}“ wirklich löschen?",
                "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
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
                EventAggregator.GetEvent<WerkzeugAddedEvent>().Publish(neuesWerkzeug);
            }
        }

        private void OnWerkzeugAdded(Werkzeug werkzeug)
        {
            werkzeug.Id = Werkzeuge.Count + 1;
            Werkzeuge.Add(werkzeug);
        }
    }
}
