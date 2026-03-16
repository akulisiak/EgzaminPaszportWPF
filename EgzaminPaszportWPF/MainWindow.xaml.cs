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

namespace EgzaminPaszportWPF
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

        private void UpdatePhoto(object sender, RoutedEventArgs e)
        {
            string numer = numerText.Text;
            
            if (numer == "000")
            {
                zdjecieImg.Source = new BitmapImage(new Uri("img/000-zdjecie.jpg", UriKind.Relative));
                odciskImg.Source = new BitmapImage(new Uri("img/000-odcisk.jpg", UriKind.Relative));
            }
            else if (numer == "111")
            {
                zdjecieImg.Source = new BitmapImage(new Uri("img/111-zdjecie.jpg", UriKind.Relative));
                odciskImg.Source = new BitmapImage(new Uri("img/111-odcisk.jpg", UriKind.Relative));
            }
            else if (numer == "333")
            {
                zdjecieImg.Source = new BitmapImage(new Uri("img/333-zdjecie.jpg", UriKind.Relative));
                odciskImg.Source = new BitmapImage(new Uri("img/333-odcisk.jpg", UriKind.Relative));
            }
            else
            {
                zdjecieImg.Source = null;
                odciskImg.Source = null;
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string numer = numerText.Text;
            string imie = imieText.Text;    
            string nazwisko = nazwiskoText.Text;
            string kolor = "";

            if (niebieskiRadio.IsChecked == true)
            {
                kolor = "niebieski";
            }
            else if (zielonyRadio.IsChecked == true)
            {
                kolor = "zielony";
            }
            else if (piwnyRadio.IsChecked == true)
            {
                kolor = "piwny";
            }

            if (numer == "" || imie == "" || nazwisko == "")
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
            }
            else
            {
                MessageBox.Show($"{imie} {nazwisko}, kolor oczu: {kolor}");
            }
        }
    }
}