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
using System.IO;

namespace YourPokemon
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int hash = 0;
            string userName = UserName.Text.ToLower();

            foreach (char item in userName)
            {
                hash += (int)item;
            }
            hash %= 151;
            

            string path = Directory.GetCurrentDirectory()+"\\Pockemons\\" + hash+".jpg";
            Pockemon.Source = new BitmapImage(new Uri(path));
        }
    }
}
