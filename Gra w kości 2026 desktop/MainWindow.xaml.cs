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

            dices = new Image[] { kosc1, kosc2, kosc3, kosc4, kosc5 };
        }

        public string[] Img = { "/Images/kosc0.png", "/Images/kosc1.png", "/Images/kosc2.png", "/Images/kosc3.png", "/Images/kosc4.png", "/Images/kosc5.png", "/Images/kosc6.png" };

        int wynik = 0;
        bool[] avaiabala = { true, true, true, true, true, true };
        int[] kosci =  {0, 0, 0, 0, 0 };
        public Image[] dices;

        Random rnd = new Random();



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wynik = 0;
            for (int i = 0; i<5; i++)
            {
                
                if (avaiabala[i])
                {
                    kosci[i] = rnd.Next(1, 7);
                    dices[i].Source = new BitmapImage(new Uri(Img[kosci[i]], UriKind.Relative));
                }
                wynik += kosci[i];
            }

            Score.Text = wynik.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (kosc1.Opacity == 0.5) kosc1.Opacity = 1;
            else kosc1.Opacity = 0.5;
            avaiabala[0] = !avaiabala[0];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (kosc2.Opacity == 0.5) kosc2.Opacity = 1;
            else kosc2.Opacity = 0.5;
            avaiabala[1] = !avaiabala[1];
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (kosc3.Opacity == 0.5) kosc3.Opacity = 1;
            else kosc3.Opacity = 0.5;
            avaiabala[2] = !avaiabala[2];
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (kosc4.Opacity == 0.5) kosc4.Opacity = 1;
            else kosc4.Opacity = 0.5;
            avaiabala[3] = !avaiabala[3];
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (kosc5.Opacity == 0.5) kosc5.Opacity = 1;
            else kosc5.Opacity = 0.5;
            avaiabala[4] = !avaiabala[4];
        }
    }
}
