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

namespace Toolyy.View
{
    /// <summary>
    /// Interaction logic for InputNameDialog.xaml
    /// </summary>
    public partial class InputNameDialog : Window
    {
        public string UserName => NameTextBox.Text;

        public InputNameDialog()
        {
            InitializeComponent();
            NameTextBox.Focus();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bitte einen Namen eingeben.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
