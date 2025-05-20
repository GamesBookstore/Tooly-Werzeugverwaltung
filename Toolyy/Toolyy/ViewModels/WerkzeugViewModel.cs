using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Common;
using Common.Command;
using Prism.Events;
using Toolyy.Events;
using Toolyy.Models;

namespace Toolyy.ViewModels
{
    public class WerkzeugViewModel : BaseViewModel
    {
        #region ---------Fields, Properties ------------------------------

        private Werkzeug _aktuellesWerkzeug;
        public ObservableCollection<Werkzeug> Werkzeuge { get; set; }

        public ICommand SaveWerkzeugCommand { get; private set; }

        public Werkzeug AktuellesWerkzeug
        {
            get => _aktuellesWerkzeug;
            set
            {
                if (_aktuellesWerkzeug != value)
                {
                    _aktuellesWerkzeug = value;
                    OnPropertyChanged(nameof(AktuellesWerkzeug));
                }
            }
        }

        #endregion

        #region ---------Constructor -------------------------------------

        public WerkzeugViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            LoadWerkzeuge();

            SaveWerkzeugCommand = new ActionCommand(SaveWerkzeugCommandExecute, SaveWerkzeugCommandCanExecute);

            EventAggregator.GetEvent<WerkzeugAddedEvent>().Subscribe(OnWerkzeugAdded, ThreadOption.UIThread);
        }

        #endregion

        #region ---------Methods -----------------------------------------

        private void LoadWerkzeuge()
        {
            Werkzeuge = new ObservableCollection<Werkzeug>
            {
                new Werkzeug { Id = 1, Name = "Schraubenzieher", Category = "Handwerkzeug", Available = true, Location = "Werkstatt A" },
                new Werkzeug { Id = 2, Name = "Bohrmaschine", Category = "Elektro", Available = false, Location = "Lager B" },
                new Werkzeug { Id = 3, Name = "Hammer", Category = "Handwerkzeug", Available = true, Location = "Werkstatt B" }
            };

            AktuellesWerkzeug = new Werkzeug();
        }

        private bool SaveWerkzeugCommandCanExecute(object parameter)
        {
            return true; 
        }

        private void SaveWerkzeugCommandExecute(object parameter)
        {
            MessageBox.Show("Werkzeugdaten gespeichert!");
        }

        private void OnWerkzeugAdded(Werkzeug werkzeug)
        {
            werkzeug.Id = Werkzeuge.Count + 1;
            Werkzeuge.Add(werkzeug);
        }

        #endregion
    }
}
