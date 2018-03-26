using System;
using System.Windows.Forms;
using capa_negocio;
using capa_entidades;
using System.Collections.Generic;

namespace capa_presentacion
{
    public partial class InsertarTwitter : Form
    {        
        private Negocio n;
        private List<TweetProgramado> tweetsProgramados;       
        private List<UserApp> usuarios;
        private int tiempo, cuenta;
        public InsertarTwitter(Negocio negocio)
        {
            n = negocio;
            InitializeComponent();
            rBtnNew.Checked = true;
            tweetsProgramados = n.cargarTweetsProgramados();
            usuarios = n.cargarUsuarios();
            cargarImagen();
            timer1.Start();
            tiempo = 0;
            txtFecha.Text = calendario.TodayDate.ToString("dd/MM/yyyy");
            timerPublicar.Start();       
        }

        private void cargarImagen()
        {
            foto.ImageLocation = n.cargarImagen();
        }

        private void publicarTweetProgramado()
        {           
            string horaActual;
            string horaTweet;           

            foreach (TweetProgramado tProg in tweetsProgramados)
            {
                horaTweet = tProg.fechaProgramacion;
                horaActual = DateTime.Now.ToString();
                string[] datosFecha = horaActual.Split('/', ' ', ':');
                string fechaTotal = datosFecha[2] + datosFecha[1] + datosFecha[0]
                    + datosFecha[3] + datosFecha[4];
                if (fechaTotal.CompareTo(tProg.fechaProgramacion) >= 0)
                {                 
                    n.mandarTweet(tProg.titulo);
                    n.eliminarTweetProgramado(tProg.id);                       
                }               
            }
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            var tweet = txtTweet.Text;
            if (txtTweet.Text.Equals(""))
            {
                timer2.Start();
                toolStripStatusLabel1.Text = "Introduzca el texto del tweet";
            }
            else
            {
                if (rBtnNew.Checked)
                {                    
                    n.mandarTweet(tweet);
                    toolStripStatusLabel1.Text = "Tweet enviado";
                    timer2.Start();
                    txtTweet.Text = "";
                }
                else
                {
                    int id;
                    //Vuelvo a cargar la lista para que cuente si se ha añadido uno nuevo
                    tweetsProgramados = n.cargarTweetsProgramados();
                    if (tweetsProgramados.Count == 0)
                        id = 1;
                    else
                        id = (tweetsProgramados[tweetsProgramados.Count - 1].id) + 1;
                    string usuario = usuarios[0].usuario;
                    string titulo = txtTweet.Text;
                    int programado = 1;
                    string fechaProgramacion;
                    string imagen = "";
                   
                    //Fecha porgramada
                    string textoFecha = txtFecha.Text;
                    string[] fecha = textoFecha.Split('/');
                    string listaHora = listHoras.SelectedItem.ToString();
                    string[] hora = listaHora.Split(':', ' ');
                    
                    fechaProgramacion = fecha[2] + fecha[1] + fecha[0]
                        + hora[0] + hora[1];

                    int resultado = n.guardarTweetBD(id, usuario, programado, 
                        fechaProgramacion, imagen, titulo);

                    if (resultado > 0)
                    {
                        toolStripStatusLabel1.Text = "Tweet Programado";
                        timer2.Start();
                        txtTweet.Text = "";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Error al programar tweet";
                        timer2.Start();
                    }
                }
            }
        }

        private void txtTweet_TextChanged(object sender, EventArgs e)
        {
            lblCaract.Text = (140 - txtTweet.Text.Length).ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = calendario.SelectionRange.Start.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            lblFecha.Text = DateTime.Now.ToString();            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo >= 4)
            {
                toolStripStatusLabel1.Text = "";
                timer2.Stop();
                tiempo = 0;               
            }
        }

        private void timerPublicar_Tick(object sender, EventArgs e)
        {            
            cuenta++;
            if (cuenta >= 59)
            {
                publicarTweetProgramado();
                cuenta = 0;
            }
        }
    }
}
