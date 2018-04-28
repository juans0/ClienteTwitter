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
    /// Lógica de interacción para PantFollowNoMeSiguen.xaml
    /// </summary>
    public partial class PantFollowNoMeSiguen : Window
    {
        Negocio n;
        List<UsuariosFollowers> misFollowers;

        public PantFollowNoMeSiguen(Negocio neg)
        {
            InitializeComponent();
            n = neg;
            misFollowers = n.obtenerFollowers();
            gridSeguidores.ItemsSource = misFollowers;
        }

        private void cambiarSeleccionGrid(object sender, SelectionChangedEventArgs e)
        {
            DataGrid nuevoData = (DataGrid)sender;
            UsuariosFollowers fila = (UsuariosFollowers)nuevoData.SelectedItem;
            nombre.Content = fila.Nombre;
            seguidores.Content = fila.Followers;
            //imagenFollower. = new BitmapImage(new Uri(temp.Imagen, UriKind.Absolute));

        }
    }
}
