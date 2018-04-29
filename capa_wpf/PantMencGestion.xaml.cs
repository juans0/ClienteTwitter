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
using capa_entidades;
using System.Windows.Threading;

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantMencGestion.xaml
    /// </summary>
    public partial class PantMencGestion : Window
    {
        Negocio n;
        List<Mencion> menciones;
        Mencion mencion;
        DispatcherTimer timer;

        public PantMencGestion(Negocio neg)
        {
            InitializeComponent();
            n = neg;
            menciones = n.obtenerMenciones();
            gridMenciones.ItemsSource = menciones;
            timer = new DispatcherTimer();
        }

        private void cambiarSeleccionGrid(object sender, SelectionChangedEventArgs e)
        {
            DataGrid nuevoData = (DataGrid)sender;
            Mencion seleccion = (Mencion)nuevoData.SelectedItem;
            txtMencion.Text = seleccion.texto;
            mencion = seleccion;                      
        }

        private void click_Retweet(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick; 

            if (mencion != null)
            {
                n.hacerRetweet(mencion);
                lblMensaje.Content = "Has retwiteado este tweet";
                timer.Start();
            }
        }

        private void click_Fav(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick;

            if (mencion != null)
            {
                n.marcarFavorito(mencion);
                lblMensaje.Content = "Has marcado este tweet como favorito";
                timer.Start();
            }
        }

        private void click_Resp(object sender, RoutedEventArgs e)
        {
            PantRespuestaTweet p = new PantRespuestaTweet(mencion, n);
            p.Show();      
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblMensaje.Content = "";
        }
    }
}
