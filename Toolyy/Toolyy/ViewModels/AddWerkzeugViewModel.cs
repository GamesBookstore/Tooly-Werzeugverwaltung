using Prism.Events;
using System.Windows.Input;
using Toolyy.Models;
using Common;
using Common.Command;
using Toolyy.Events;

namespace Toolyy.ViewModels
{
    public class AddWerkzeugViewModel : BaseViewModel
    {
        public Werkzeug NeuesWerkzeug { get; set; } = new Werkzeug();

        public ICommand AddWerkzeugCommand { get; set; }

        public AddWerkzeugViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            AddWerkzeugCommand = new ActionCommand(ExecuteAddWerkzeug, CanExecuteAddWerkzeug);
        }

        private bool CanExecuteAddWerkzeug(object parameter)
        {
            return !string.IsNullOrWhiteSpace(NeuesWerkzeug.Name);
        }

        private void ExecuteAddWerkzeug(object parameter)
        {
            NeuesWerkzeug.Id = 0; 
            EventAggregator.GetEvent<WerkzeugAddedEvent>().Publish(NeuesWerkzeug);
            NeuesWerkzeug = new Werkzeug(); 
            OnPropertyChanged(nameof(NeuesWerkzeug));
        }
    }
}
