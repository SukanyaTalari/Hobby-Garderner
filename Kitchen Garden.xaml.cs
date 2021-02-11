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
using Wpf_Gardening_Project.Kitchen;

namespace Wpf_Gardening_Project
{
    /// <summary>
    /// Interaction logic for Kitchen_Garden.xaml
    /// </summary>
    public partial class Kitchen_Garden : UserControl
    {
        public Kitchen_Garden()
        {
            InitializeComponent();
        }

        private void btn_Tomatoes_Click(object sender, RoutedEventArgs e)
        {
            Tomatoes tomatoes = new Tomatoes();
            tomatoes.Show();
        }

        private void btn_Zucchini_Click(object sender, RoutedEventArgs e)
        {
            Zucchini zucchini = new Zucchini();
            zucchini.Show();
        }

        private void btn_BellPeppers_Click(object sender, RoutedEventArgs e)
        {
            Bell_Peppers bell = new Bell_Peppers();
            bell.Show();
        }

        private void btn_Cabbage_Click(object sender, RoutedEventArgs e)
        {
            Cabbage cabbage = new Cabbage();
            cabbage.Show();
        }

        private void btn_Beans_Click(object sender, RoutedEventArgs e)
        {
            Beans beans = new Beans();
            beans.Show();
        }

        private void btn_Lettuce_Click(object sender, RoutedEventArgs e)
        {
            Lettuce lettuce = new Lettuce();
            lettuce.Show();
        }

        private void btn_BeetRoots_Click(object sender, RoutedEventArgs e)
        {
            Beet_Roots beet = new Beet_Roots();
            beet.Show();
        }

        private void btn_Carrots_Click(object sender, RoutedEventArgs e)
        {
            Carrots carrots = new Carrots();
            carrots.Show();
        }

        private void btn_Radishes_Click(object sender, RoutedEventArgs e)
        {
            Radishes radishes = new Radishes();
            radishes.Show();
        }

        private void btn_Mint_Click(object sender, RoutedEventArgs e)
        {
            Mint mint = new Mint();
            mint.Show();
        }

        private void btn_Chillies_Click(object sender, RoutedEventArgs e)
        {
            Chillies chillies = new Chillies();
            chillies.Show();
        }

        private void btn_Corinder_Click(object sender, RoutedEventArgs e)
        {
            Corinder corinder = new Corinder();
            corinder.Show();
        }

        private void btn_Lemon_Click(object sender, RoutedEventArgs e)
        {
            Lemon lemon = new Lemon();
            lemon.Show();
        }

        private void btn_Oregano_Click(object sender, RoutedEventArgs e)
        {
            Oregano oregano = new Oregano();
            oregano.Show();
        }
    }
}
