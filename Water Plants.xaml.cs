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
using Wpf_Gardening_Project.Water;

namespace Wpf_Gardening_Project
{
    /// <summary>
    /// Interaction logic for Water_Plants.xaml
    /// </summary>
    public partial class Water_Plants : UserControl
    {
        public Water_Plants()
        {
            InitializeComponent();
        }

        private void btn_CallaLily_Click(object sender, RoutedEventArgs e)
        {
            Calla_Lily calla = new Calla_Lily();
            calla.Show();
        }

        private void btn_AmazonFrogbit_Click(object sender, RoutedEventArgs e)
        {
            Amazon_Frogbit frogbi = new Amazon_Frogbit();
            frogbi.Show();
        }

        private void btn_ParrotsFeather_Click(object sender, RoutedEventArgs e)
        {
            Parrots_Feather parfe = new Parrots_Feather();
            parfe.Show();
        }

        private void btn_MosquitoFern_Click(object sender, RoutedEventArgs e)
        {
            Mosquito_Fern mosqfe = new Mosquito_Fern();
            mosqfe.Show();
        }

        private void btn_Hornwort_Click(object sender, RoutedEventArgs e)
        {
            Hornwort hornw = new Hornwort();
            hornw.Show();
        }

        private void btn_Duckweed_Click(object sender, RoutedEventArgs e)
        {
            Duckweed ducw = new Duckweed();
            ducw.Show();
        }

        private void btn_WaterHyacinth_Click(object sender, RoutedEventArgs e)
        {
            Water_Hyacinth wahya = new Water_Hyacinth();
            wahya.Show();
        }

        private void btn_WaterSpangle_Click(object sender, RoutedEventArgs e)
        {
            Water_Spangle waspa = new Water_Spangle();
            waspa.Show();
        }

        private void btn_CreepingJenny_Click(object sender, RoutedEventArgs e)
        {
            Creeping_Jenny creje = new Creeping_Jenny();
            creje.Show();
        }

        private void btn_RoughHorsetail_Click(object sender, RoutedEventArgs e)
        {
            Rough_Horsetail rouho = new Rough_Horsetail();
            rouho.Show();
        }

        private void btn_Lotus_Click(object sender, RoutedEventArgs e)
        {
            Lotus lotu = new Lotus();
            lotu.Show();
        }

        private void btn_UmbrellaPalm_Click(object sender, RoutedEventArgs e)
        {
            Umbrella_Palm umbpa = new Umbrella_Palm();
            umbpa.Show();
        }

        private void btn_WaterForgetMeNot_Click(object sender, RoutedEventArgs e)
        {
            Water_Forget_Me_Not wafome = new Water_Forget_Me_Not();
            wafome.Show();
        }

        private void btn_MosaicFlower_Click(object sender, RoutedEventArgs e)
        {
            Mosaic_Flower mosic = new Mosaic_Flower();
            mosic.Show();
        }
    }
}
