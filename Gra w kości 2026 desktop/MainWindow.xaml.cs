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

namespace Gra_w_kości_2026_desktop
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (kosc1.Opacity == 0.5) kosc1.Opacity = 1;
            else kosc1.Opacity = 0.5;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (kosc2.Opacity == 0.5) kosc2.Opacity = 1;
            else kosc2.Opacity = 0.5;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (kosc3.Opacity == 0.5) kosc3.Opacity = 1;
            else kosc3.Opacity = 0.5;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (kosc4.Opacity == 0.5) kosc4.Opacity = 1;
            else kosc4.Opacity = 0.5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (kosc5.Opacity == 0.5) kosc5.Opacity = 1;
            else kosc5.Opacity = 0.5;
        }
    }
}
