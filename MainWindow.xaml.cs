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

namespace Earthworms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Earthworms Copyright (c) Nigel Booth 2022 for Mogpie
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeadBtn_Click(object sender, RoutedEventArgs e)
        {
            // Anatomical diagram of head
            Head head = new Head();
            head.Show();
        }

        private void ClitBtn_Click(object sender, RoutedEventArgs e)
        {
            //May not be the best choice of name but as the earthworm has a clitellum...
            Clit clit = new Clit();
            clit.Show();
        }

        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            //Shows information about earthworms
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            //Close application
            Application.Current.Shutdown();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Earthworms  Copyright N.Booth 2022 for Mogpie");
        }
    }
}
