using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Toolyy.ViewModels
{
    public class BaseViewModel : NotifyPropertyChanged
    {
        protected IEventAggregator EventAggregator { get; }

        public BaseViewModel(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(EventAggregator));
        }
    }
}
