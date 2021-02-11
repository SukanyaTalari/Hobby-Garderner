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
using Wpf_Gardening_Project.Outdoor;

namespace Wpf_Gardening_Project
{
    /// <summary>
    /// Interaction logic for Outdoor_Plants.xaml
    /// </summary>
    public partial class Outdoor_Plants : UserControl
    {
        public Outdoor_Plants()
        {
            InitializeComponent();
        }


        private void btn_Hydrangea_Click(object sender, RoutedEventArgs e)
        {
            Hydrangea hydrangea = new Hydrangea();
            hydrangea.Show();
        }

        private void btn_Cuphea_Click(object sender, RoutedEventArgs e)
        {
            Cuphea cupha = new Cuphea();
            cupha.Show();
        }

        private void btn_Lavender_Click(object sender, RoutedEventArgs e)
        {
            Lavender laven = new Lavender();
            laven.Show();
        }

        private void btn_CannaLily_Click(object sender, RoutedEventArgs e)
        {
            Canna_Lily cannli = new Canna_Lily();
            cannli.Show();
        }

        private void btn_Strawberry_Click(object sender, RoutedEventArgs e)
        {
            Strawberry strwb = new Strawberry();
            strwb.Show();
        }

        private void btn_Mandevilla_Click(object sender, RoutedEventArgs e)
        {
            Mandevilla mandev = new Mandevilla();
            mandev.Show();
        }

        private void btn_Rose_Click(object sender, RoutedEventArgs e)
        {
            Rose rose = new Rose();
            rose.Show();
        }

        private void btn_SusanVine_Click(object sender, RoutedEventArgs e)
        {
            Black_eyed_Susan_Vine blesvi = new Black_eyed_Susan_Vine();
            blesvi.Show();
        }

        private void btn_Verbena_Click(object sender, RoutedEventArgs e)
        {
            Verbena verbn = new Verbena();
            verbn.Show();
        }

        private void btn_CardinalClimber_Click(object sender, RoutedEventArgs e)
        {
            Cardinal_Climber carcli = new Cardinal_Climber();
            carcli.Show();
        }

        private void btn_Calibrachoa_Click(object sender, RoutedEventArgs e)
        {
            Calibrachoa calibra = new Calibrachoa();
            calibra.Show();
        }

        private void btn_Begonia_Click(object sender, RoutedEventArgs e)
        {
            Begonia begoni = new Begonia();
            begoni.Show();
        }

        private void btn_Chrysanthemum_Click(object sender, RoutedEventArgs e)
        {
            Chrysanthemum chrysanthemum = new Chrysanthemum();
            chrysanthemum.Show();
        }

        private void btn_Herbs_Click(object sender, RoutedEventArgs e)
        {
            Herbs herbs = new Herbs();
            herbs.Show();
        }
    }
}
