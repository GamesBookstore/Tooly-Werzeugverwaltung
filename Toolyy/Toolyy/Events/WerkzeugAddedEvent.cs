using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Toolyy.Models;

namespace Toolyy.Events
{
    public class WerkzeugAddedEvent : PubSubEvent<Werkzeug>
    {
    }
}