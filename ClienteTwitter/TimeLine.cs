using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidades;
using capa_negocio;

namespace capa_presentacion
{
    public partial class TimeLine : Form
    {
        Negocio n;
        List<TLineTweets> listaTweets;
        public TimeLine(Negocio negocio)
        {
            n = negocio;
            InitializeComponent();
            
            listaTweets = n.cargarTimeLine();
            cargaTimeLine();
        }

        public void cargaTimeLine()
        {
            tableLayoutPanel1.AutoScroll = true;

            for (int i = 0; i < listaTweets.Count; i++)
            {
                Label fecha = new Label();
                fecha.AutoSize = true;

                Label texto = new Label();               
                texto.AutoSize = true;                

                PictureBox imagen = new PictureBox();
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.FlowDirection = FlowDirection.TopDown;                

                imagen.ImageLocation = listaTweets[i].Imagen;
                fecha.Text = listaTweets[i].Fecha.ToString();
                texto.Text = listaTweets[i].Texto.ToString();

                tableLayoutPanel1.Controls.Add(imagen);
                tableLayoutPanel1.SetRow(imagen, i);
                tableLayoutPanel1.SetColumn(imagen, 0);

                tableLayoutPanel1.Controls.Add(panel);
                tableLayoutPanel1.SetRow(panel, i);
                tableLayoutPanel1.SetColumn(panel, 1);

                panel.Controls.Add(texto);
                panel.Controls.Add(fecha);

                tableLayoutPanel1.RowCount++;
            }
        }
    }
}
