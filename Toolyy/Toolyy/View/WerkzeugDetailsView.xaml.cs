using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Toolyy.Models;
using Toolyy.ViewModels;

namespace Toolyy.View
{
    /// <summary>
    /// Interaction logic for WerkzeugDetailsView.xaml
    /// </summary>
    public partial class WerkzeugDetailsView : Window
    {
        public WerkzeugDetailsView(Werkzeug werkzeug)
        {
            InitializeComponent();
            DataContext = new WerkzeugDetailsViewModel(werkzeug);
        }
    }
}
