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
    public partial class Principal : Form
    {       
        UsuariosApp usuariosApp;
        InsertarTwitter insertTwitter;
        Followers followers;
        TimeLine timeline;
        ModificarTweet modificar;
        
        private List<UserApp> listaUsuarios;
        private Negocio negocio;        

        public Principal(string nombre)
        {            
            InitializeComponent();
            
            negocio = new Negocio();
            listaUsuarios = negocio.cargarUsuarios();
            toolStripStatusLabel.Text = "Usuario: " + nombre;     
        }

        private void itemImportUser_Click(object sender, EventArgs e)
        {
            negocio.cargarFichero();
            listaUsuarios = negocio.cargarUsuarios();
        }

        private void menuUserApp_Click(object sender, EventArgs e)
        {
            if (usuariosApp == null)
            {
                usuariosApp = new UsuariosApp(negocio);
                usuariosApp.MdiParent = this;
                usuariosApp.Dock = DockStyle.Fill;
                usuariosApp.FormClosed += new FormClosedEventHandler(cerrarFormUsuariosApp);                
                usuariosApp.Show();
            }
            else
            {
                usuariosApp.Activate();
            }
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insertTwitter == null)
            {
                insertTwitter = new InsertarTwitter(negocio);
                insertTwitter.MdiParent = this;
                insertTwitter.Dock = DockStyle.Fill;
                insertTwitter.FormClosed += new FormClosedEventHandler(cerrarInsertTwitter);
                insertTwitter.Show();
            }
            else
            {
                insertTwitter.Activate();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modificar == null)
            {
                modificar = new ModificarTweet(negocio);
                modificar.MdiParent = this;
                modificar.Dock = DockStyle.Fill;
                modificar.FormClosed += new FormClosedEventHandler(cerrarModicar);
                modificar.Show();
            }
            else
            {
                modificar.Activate();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modificar == null)
            {
                modificar = new ModificarTweet(negocio);
                modificar.MdiParent = this;
                modificar.Dock = DockStyle.Fill;
                modificar.FormClosed += new FormClosedEventHandler(cerrarModicar);
                modificar.Show();
            }
            else
            {
                modificar.Activate();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (followers == null)
            {
                followers = new Followers(negocio);
                followers.MdiParent = this;
                followers.Dock = DockStyle.Fill;
                followers.FormClosed += new FormClosedEventHandler(cerrarFollowers);
                followers.Show();
            }
            else
            {
                followers.Activate();
            }
        }

        private void menuTimeLine_Click(object sender, EventArgs e)
        {
            if (timeline == null)
            {
                timeline = new TimeLine(negocio);
                timeline.MdiParent = this;
                timeline.Dock = DockStyle.Fill;
                timeline.FormClosed += new FormClosedEventHandler(cerrarTimeline);
                timeline.Show();
            }
            else
            {
                timeline.Activate();
            }
        }

        private void cerrarFormUsuariosApp(object sender, EventArgs e)
        {
            usuariosApp = null;
        }

        private void cerrarInsertTwitter(object sender, EventArgs e)
        {
            insertTwitter = null;
        }

        private void cerrarFollowers(object sender, EventArgs e)
        {
            followers = null;
        }

        private void cerrarTimeline(object sender, EventArgs e)
        {
            timeline = null;
        }

        private void cerrarModicar(object sender, EventArgs e)
        {
            modificar = null;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
