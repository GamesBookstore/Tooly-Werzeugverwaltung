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

namespace Toolyy.View
{
    /// <summary>
    /// Interaction logic for AddWerkzeugView.xaml
    /// </summary>
    public partial class AddWerkzeugView : Window
    {
        public Werkzeug NeuesWerkzeug { get; private set; }

        public AddWerkzeugView(Werkzeug werkzeug)
        {
            InitializeComponent();
            AktuellesWerkzeug = werkzeug;
            DataContext = this;
        }

        public Werkzeug AktuellesWerkzeug { get; set; }

        private void Hinzufuegen_Click(object sender, RoutedEventArgs e)
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
