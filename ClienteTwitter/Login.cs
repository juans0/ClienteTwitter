using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;
using capa_entidades;

namespace capa_presentacion
{
    public partial class Login : Form
    {
        Principal principal;
        private int cont;
        private int tiempo;
        private Negocio negocio;
        private List<UserApp> listaUsuarios;

        public Login()
        {
            negocio = new Negocio();
            listaUsuarios = negocio.cargarUsuarios();
            InitializeComponent();            
            cont = 0;
            tiempo = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            if (txtUsuario.Text == "" || txtContrasenia.Text == "")
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Introduzca usuario y contraseña";
                timer1.Start();
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                txtUsuario.Focus();                         
            }    
            else
            {
                //Console.WriteLine(listaUsuarios[0].usuario + " " + listaUsuarios[0].contrasenia);  
                //if (txtUsuario.Text == "administrador" &&
                //txtContrasenia.Text == "admin")
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (txtUsuario.Text == listaUsuarios[i].usuario
                    && txtContrasenia.Text == listaUsuarios[i].contrasenia)
                    {
                        string nombre = listaUsuarios[i].nombre;
                        int id = listaUsuarios[i].idUsuario;
                        principal = new Principal(nombre);
                        this.Hide();
                        principal.Show();
                    }
                    else
                    {
                        cont++;
                        if (cont >= 3)
                            this.Close();
                        else
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "Usuario o contraseña incorrectos";
                            timer1.Start();
                            txtUsuario.Text = "";
                            txtContrasenia.Text = "";
                            txtUsuario.Focus();
                        }
                    }
                }
                           
            }        
        }       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo >= 4)
            {
                lblError.Text = "";
                timer1.Stop();
            }
                
        }
    }
}
