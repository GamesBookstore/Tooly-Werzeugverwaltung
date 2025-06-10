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
using Toolyy.Models;
using Toolyy.ViewModels;

namespace Toolyy.View
{
    /// <summary>
    /// Interaction logic for EditWerkzeugView.xaml
    /// </summary>
    public partial class EditWerkzeugView : Window
    {
        public EditWerkzeugView(Werkzeug werkzeug, IEventAggregator eventAggregator)
        {
            InitializeComponent();
            DataContext = new EditWerkzeugViewModel(werkzeug, eventAggregator);
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
