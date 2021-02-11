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
using Wpf_Gardening_Project.Indoor;

namespace Wpf_Gardening_Project
{
    /// <summary>
    /// Interaction logic for Indoor_Plants.xaml
    /// </summary>
    public partial class Indoor_Plants : UserControl
    {
        public Indoor_Plants()
        {
            InitializeComponent();

        }



        private void btn_AsparagusFern_Click(object sender, RoutedEventArgs e)
        {
            Asparagus_Fern afern = new Asparagus_Fern();
            afern.Show();
        }

        private void btn_ChineseEvergreen_Click(object sender, RoutedEventArgs e)
        {
            ChineseEvergreen chiever = new ChineseEvergreen();
            chiever.Show();
        }

        private void btn_FiddleFig_Click(object sender, RoutedEventArgs e)
        {
            Fiddle_Leaf_Fig fiddle = new Fiddle_Leaf_Fig();
            fiddle.Show();
        }

        private void btn_GuianaChestnut_Click(object sender, RoutedEventArgs e)
        {
            Guiana_Chestnut chestnut = new Guiana_Chestnut();
            chestnut.Show();
        }

        private void btn_ChineseMoneyPlant_Click(object sender, RoutedEventArgs e)
        {
            Chinese_Money_Plant chmop = new Chinese_Money_Plant();
            chmop.Show();
        }

        private void btn_Yucca_Click(object sender, RoutedEventArgs e)
        {
            Yucca yucca = new Yucca();
            yucca.Show();
        }

        private void btn_AfricanViolets_Click(object sender, RoutedEventArgs e)
        {
            African_Violets violets = new African_Violets();
            violets.Show();
        }

        private void btn_AirPlant_Click(object sender, RoutedEventArgs e)
        {
            Air_Plant airpl = new Air_Plant();
            airpl.Show();
        }

        private void btn_SpiderPlant_Click(object sender, RoutedEventArgs e)
        {
            Spider_Plant spipl = new Spider_Plant();
            spipl.Show();
        }

        private void btn_PeaceLily_Click(object sender, RoutedEventArgs e)
        {
            Peace_Lily peali = new Peace_Lily();
            peali.Show();
        }

        private void btn_AloeVeera_Click(object sender, RoutedEventArgs e)
        {
            Aloe_Veera aloeve = new Aloe_Veera();
            aloeve.Show();
        }

        private void btn_EnglishIvy_Click(object sender, RoutedEventArgs e)
        {
            English_Ivy engiv = new English_Ivy();
            engiv.Show();
        }

        private void btn_DragonTree_Click(object sender, RoutedEventArgs e)
        {
            Dragon_Tree drgtr = new Dragon_Tree();
            drgtr.Show();
        }

        private void btn_Peperomia_Click(object sender, RoutedEventArgs e)
        {
            Peperomia pepro = new Peperomia();
            pepro.Show();
        }
    }

}
