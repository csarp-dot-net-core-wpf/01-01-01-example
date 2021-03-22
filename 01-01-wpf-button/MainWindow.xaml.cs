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

namespace _01_01_wpf_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            // S1.07 A Click eseményhez rendelt kód
            //       A txtHello TextBlock feliratát (Text) megváltoztatjuk.
            //       A btnDeleteText gombot megjeleníti.
            txtHello.Text = "Helló világ!";
            btnDeleteText.Visibility = Visibility.Visible;
        }

        private void btnDeleteText_Click(object sender, RoutedEventArgs e)
        {
            // S1.09 A másik Click eseményhez rendelt kód
            //       A txtHello TextBlock szövegét törli.
            //       A btnDeleteText gombot eltünteti.
            txtHello.Text = string.Empty;
            btnDeleteText.Visibility = Visibility.Hidden;
        }
    }
}
