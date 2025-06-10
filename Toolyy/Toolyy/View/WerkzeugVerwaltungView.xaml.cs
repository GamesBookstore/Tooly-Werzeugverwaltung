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
using System.Windows.Shapes;
using Toolyy.ViewModels;

namespace Toolyy.View
{
    /// <summary>
    /// Interaction logic for WerkzeugListeView.xaml
    /// </summary>
    public partial class WerkzeugVerwaltungView : Window
    {
        public WerkzeugVerwaltungView()
        {
            InitializeComponent();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is WerkzeugVerwaltungViewModel viewModel && viewModel.AusgewaehltesWerkzeug != null)
            {
                var detailsWindow = new WerkzeugDetailsView(viewModel.AusgewaehltesWerkzeug);
                detailsWindow.Owner = this;
                detailsWindow.ShowDialog();
            }
        }


    }
}
