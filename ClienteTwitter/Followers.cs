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
    public partial class Followers : Form
    {
        Negocio negocio;
        List<UsuariosFollowers> listaFollowers;
        public Followers(Negocio n)
        {
            negocio = n;
            listaFollowers = new List<UsuariosFollowers>();
            listaFollowers = negocio.obtenerFollowers();
            InitializeComponent();
            cargarFollowers();
        }

        public void cargarFollowers()
        {
            FlowLayoutPanel flowLayoutPanel1;
            tLPanel.AutoScroll = true;

            for (int i = 0; i < listaFollowers.Count; i++)
            {
                Label nombre = new Label();
                nombre.AutoSize = true;
                Label followers = new Label();
                followers.AutoSize = true;

                PictureBox imagen = new PictureBox();
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
             
                flowLayoutPanel1 = new FlowLayoutPanel();
                flowLayoutPanel1.AutoSize = true;
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                                
                imagen.ImageLocation = listaFollowers[i].Imagen;
                nombre.Text = listaFollowers[i].Nombre;
                followers.Text = "Followers: " +
                    listaFollowers[i].Followers.ToString();

                tLPanel.Controls.Add(imagen);
                tLPanel.SetRow(imagen, i);
                tLPanel.SetColumn(imagen, 0);

                tLPanel.Controls.Add(flowLayoutPanel1);
                tLPanel.SetRow(flowLayoutPanel1, i);
                tLPanel.SetColumn(flowLayoutPanel1, 1);
                
                flowLayoutPanel1.Controls.Add(nombre);
                flowLayoutPanel1.Controls.Add(followers);

                tLPanel.RowCount++;
            }
        }
    }
}
