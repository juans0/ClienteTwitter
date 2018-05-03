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
using capa_negocio;

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantFollowTodos.xaml
    /// </summary>
    public partial class PantFollowTodos : Window
    {
        Negocio n;
        List<UsuariosFollowers> misFollowers;

        public PantFollowTodos(Negocio neg)
        {
            InitializeComponent();
            n = neg;
            misFollowers = n.obtenerFollowers();
            gridSeguidores.ItemsSource = misFollowers;
        }

        private void cambiarSeleccionGrid(object sender, SelectionChangedEventArgs e)
        {
            DataGrid nuevoData = (DataGrid)sender;
            UsuariosFollowers followers = (UsuariosFollowers)nuevoData.SelectedItem;
            nombre.Content = followers.Nombre;
            seguidores.Content = followers.Followers;
            imagen.Source = new BitmapImage(new Uri(followers.Imagen, UriKind.Absolute));
        }
    }
}
