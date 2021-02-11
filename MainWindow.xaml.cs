using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Wpf_Gardening_Project;

namespace Wpf_Gardening_Project
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
            setActiveUserControl(home);
        }

        public void setActiveUserControl(UserControl control)
        {
            home.Visibility = Visibility.Collapsed;
            indoor.Visibility = Visibility.Collapsed;
            outdoor.Visibility = Visibility.Collapsed;
            water.Visibility = Visibility.Collapsed;
            kitchen.Visibility = Visibility.Collapsed;
            kultur.Visibility = Visibility.Collapsed;
            organic.Visibility = Visibility.Collapsed;
            ferti.Visibility = Visibility.Collapsed;
            //game.Visibility = Visibility.Collapsed;
            community.Visibility = Visibility.Collapsed;


            control.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(indoor);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(outdoor);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(water);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(kitchen);
        }

 
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(organic);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(kultur);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(ferti);
        }

        //private void Button_Click_9(object sender, RoutedEventArgs e)
        //{
        //    setActiveUserControl(game);
        //}

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(community);
        }

        private void Window_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(home);
            
        }

    }
}
