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

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para Principal_wpf.xaml
    /// </summary>
    public partial class Principal_wpf : Window
    {
        public Principal_wpf(string nombre)
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Salir(object sender, RoutedEventArgs e)
        {
            PantFollowers.Visibility = Visibility.Collapsed;
            PantPromociones.Visibility = Visibility.Collapsed;
            PantMenciones.Visibility = Visibility.Collapsed;        
            PantArchivo.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_Todos(object sender, RoutedEventArgs e)
        {
            PantPromociones.Visibility = Visibility.Collapsed;
            PantMenciones.Visibility = Visibility.Collapsed;
            PantArchivo.Visibility = Visibility.Collapsed;
            PantFollowers.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_NoSigo(object sender, RoutedEventArgs e)
        {
            PantFollowers.Visibility = Visibility.Collapsed;
            PantPromociones.Visibility = Visibility.Collapsed;
            PantArchivo.Visibility = Visibility.Collapsed;
            PantMenciones.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_NoMeSiguen(object sender, RoutedEventArgs e)
        {
            PantFollowers.Visibility = Visibility.Collapsed;
            PantPromociones.Visibility = Visibility.Collapsed;
            PantArchivo.Visibility = Visibility.Collapsed;
            PantPromociones.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_Menciones(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_Promociones(object sender, RoutedEventArgs e)
        {

        }
    }               
}
