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
using System.Windows.Shapes;

namespace Earthworms
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void InfoList_Loaded(object sender, RoutedEventArgs e)
        {
            InfoList.Items.Add("Earthworm");
            InfoList.Items.Add("Kingdom        Animalia");
            InfoList.Items.Add("Phylum         Annelida");
            InfoList.Items.Add("Class          Clitellata");
            InfoList.Items.Add("Order          Opisthopora");
            InfoList.Items.Add("Suborder       Lumbricina");
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
