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

using _01_02_button_click_animal_say.model;

namespace _01_02_button_click_animal_say
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // S2.07 A MainWindows egy osztály. Felveszünk benne egy Cat adattagot.
        private Cat luna;

        public MainWindow()
        {
            // S2.08 Az osztály konstruktorába példányosítjuk a macskát
            luna = new Cat("Luna");
            InitializeComponent();
        }

        private void btnCat_Click(object sender, RoutedEventArgs e)
        {
            // S2.09 Megjelenítjük a köszöntő szöveget és láthatóvá tesszük a törlő gombot
            txtCat.Text = luna.ToString();
            btnCatTextDelete.Visibility = Visibility.Visible;
        }

        private void btnCatTextDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
