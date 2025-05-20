using Common.Command;
using System.Windows.Controls;
using System.Windows.Input;
using Toolyy.View;
using Toolyy.ViewModels;
using Prism.Events;
using Toolyy.View;

namespace Toolyy.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region ---------Fields, Constants, Delegates, Events ------------

       

        private WerkzeugViewModel werkzeugViewModel;

        #endregion

        #region ----------Constructors, Destructors, Dispose, Clone-------

        /// <summary>
        /// Initializes an instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            werkzeugViewModel = new WerkzeugViewModel(eventAggregator);

            WerkzeugViewCommand = new ActionCommand(WerkzeugViewCommandExecute, WerkzeugViewCommandCanExecute);
            AddWerkzeugViewCommand = new ActionCommand(AddWerkzeugViewCommandExecute, AddWerkzeugViewCommandCanExecute);
        }

        #endregion

        #region---------Properties, Indexers ----------------------------

        public ICommand WerkzeugViewCommand { get; private set; }
        public ICommand AddWerkzeugViewCommand { get; private set; }

       

        #endregion

        #region---------Commands -----------------------------------------

        private bool WerkzeugViewCommandCanExecute(object parameter)
        {
            return true;
        }
        private void WerkzeugViewCommandExecute(object parameter)
        {
            var window = new WerkzeugListeView
            {
                DataContext = werkzeugViewModel
            };
            window.Show();
        }


        private bool AddWerkzeugViewCommandCanExecute(object parameter)
        {
            return true;
        }

        private void AddWerkzeugViewCommandExecute(object parameter)
        {
            var window = new AddWerkzeugView(); 
            window.ShowDialog(); 
        }

        #endregion
    }
}
