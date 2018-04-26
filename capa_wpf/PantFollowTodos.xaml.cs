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
            DataGrid data = (DataGrid)sender;
            UsuariosFollowers fila = (UsuariosFollowers)data.SelectedItem;
            mostrarDetalles(fila);
        }

        private void mostrarDetalles(UsuariosFollowers temp)
        {
            nombre.Content = temp.Nombre;            
            seguidores.Content = temp.Followers;
            //imagenFollower. = new BitmapImage(new Uri(temp.Imagen, UriKind.Absolute));
        }
    }
}
