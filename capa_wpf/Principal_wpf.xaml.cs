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
        MainWindow mWindow;

        public Principal_wpf(string nombre)
        {
            InitializeComponent();
            mWindow = new MainWindow();
        }

        private void MenuItem_Click_Salir(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Cliente Twitter",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                mWindow.Show();
                Close();
            }
        }

        private void MenuItem_Click_Todos(object sender, RoutedEventArgs e)
        {
            PantArchSalir.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantFollowTodos.Visibility = Visibility.Visible;            
        }

        private void MenuItem_Click_NoSigo(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;          
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_NoMeSiguen(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Visible;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click_Recibir(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Visible;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click_GestMen(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Visible;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click_Eliminar(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Visible;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click_Alta(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Visible;
            PantPromoGestion.Visibility = Visibility.Collapsed;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click_GestPromo(object sender, RoutedEventArgs e)
        {
            PantFollowTodos.Visibility = Visibility.Collapsed;
            PantFollowNoSigo.Visibility = Visibility.Collapsed;
            PantFollowNoMeSiguen.Visibility = Visibility.Collapsed;
            PantMencRecibir.Visibility = Visibility.Collapsed;
            PantMencGestion.Visibility = Visibility.Collapsed;
            PantMencEliminar.Visibility = Visibility.Collapsed;
            PantPromoAlta.Visibility = Visibility.Collapsed;
            PantPromoGestion.Visibility = Visibility.Visible;
            PantArchSalir.Visibility = Visibility.Collapsed;
        }
    }               
}
