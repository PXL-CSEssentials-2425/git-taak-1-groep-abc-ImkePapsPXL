using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace taak_1
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

        private void red_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
            
        }

        private void green_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        
        }

        private void yellow_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
            
        }

        private void blue_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
           
        }

        private void red_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void green_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void yellow_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void blue_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void green_MouseDown(object sender, MouseButtonEventArgs e)
        {
           kleurCode.Text = "#008000".ToString();
            informatie.Text = "Groen is de kleur van genezing".ToString();
        }

        private void red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#FF0000".ToString();
            informatie.Text = "Rood is de kleur van warmte".ToString();
        }

        private void yellow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#FFFF00".ToString();
            informatie.Text = "Geel is de kleur van levenslust".ToString();
        }

        private void blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#0000FF".ToString();
            informatie.Text = "Blauw is de kleur van intelligentie".ToString();
        }
    }
}