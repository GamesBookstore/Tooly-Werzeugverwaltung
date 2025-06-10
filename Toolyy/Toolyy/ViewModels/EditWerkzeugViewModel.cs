using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolyy.Models;
using Common;

namespace Toolyy.ViewModels
{
    public class EditWerkzeugViewModel : BaseViewModel
    {
        public Werkzeug Werkzeug { get; set; }

        public EditWerkzeugViewModel(Werkzeug werkzeug, IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Werkzeug = werkzeug;
        }
    }
}


