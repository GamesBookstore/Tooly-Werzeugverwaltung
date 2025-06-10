using Common.Command;
using System.Windows.Input;
using Toolyy.View;
using Prism.Events;
using Toolyy.Models;
using Toolyy.ViewModels;
using Toolyy.Events;

namespace Toolyy.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region --------- Fields, Constants, Delegates, Events ----------

        private WerkzeugListeViewModel werkzeugListeViewModel;

        #endregion

        #region ---------- Constructors, Destructors, Dispose, Clone ----

        /// <summary>
        /// Initializes an instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            werkzeugListeViewModel = new WerkzeugListeViewModel(eventAggregator);

            WerkzeugViewCommand = new ActionCommand(WerkzeugViewCommandExecute, WerkzeugViewCommandCanExecute);
            AddWerkzeugViewCommand = new ActionCommand(AddWerkzeugViewCommandExecute, AddWerkzeugViewCommandCanExecute);
            ManageWerkzeugViewCommand = new ActionCommand(ManageWerkzeugViewCommandExecute, _ => true);

        }

        #endregion

        #region --------- Properties, Indexers --------------------------

        public ICommand WerkzeugViewCommand { get; private set; }
        public ICommand AddWerkzeugViewCommand { get; private set; }
        public ICommand ManageWerkzeugViewCommand { get; private set; }


        #endregion

        #region --------- Commands --------------------------------------

        private bool WerkzeugViewCommandCanExecute(object parameter)
        {
            return true;
        }

        private void WerkzeugViewCommandExecute(object parameter)
        {
            var window = new WerkzeugListeView
            {
                DataContext = werkzeugListeViewModel
            };
            window.Show();
        }

        private bool AddWerkzeugViewCommandCanExecute(object parameter)
        {
            return true;
        }

        private void AddWerkzeugViewCommandExecute(object parameter)
        {
            var neuesWerkzeug = new Werkzeug();
            var dialog = new AddWerkzeugView(neuesWerkzeug);

            if (dialog.ShowDialog() == true)
            {
                
                EventAggregator.GetEvent<WerkzeugAddedEvent>().Publish(neuesWerkzeug);
            }
        }

        private void ManageWerkzeugViewCommandExecute(object parameter)
        {
            var viewModel = new WerkzeugVerwaltungViewModel(EventAggregator);
            var view = new WerkzeugVerwaltungView
            {
                DataContext = viewModel
            };
            view.Show();
        }


        #endregion
    }
}
