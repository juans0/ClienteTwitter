using capa_entidades;
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
using System.Windows.Threading;

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantRespuestaTweet.xaml
    /// </summary>
    public partial class PantRespuestaTweet : Window
    {
        Negocio n;
        Mencion menc;
        DispatcherTimer timer;

        public PantRespuestaTweet(Mencion m, Negocio neg)
        {
            InitializeComponent();
            n = neg;
            menc = m;
            timer = new DispatcherTimer();
            txtMencion.Text = m.texto;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string texto = txtResp.Text;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick;

            if (menc != null && texto != "")
            {
                n.responderTweet(menc, texto);
                lblMensaje.Content = "Has respondido a este tweet";
                timer.Start();               
            }
            else
            {
                lblMensaje.Content = "Error al responder a este tweet";
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblMensaje.Content = "";
            Close();
        }
    }
}
