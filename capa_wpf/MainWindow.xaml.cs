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
using System.Windows.Navigation;
using System.Windows.Shapes;
using capa_negocio;
using capa_presentacion;
using capa_entidades;
using System.Windows.Threading;

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cont;        
        private Negocio negocio;
        private List<UserApp> listaUsuarios;
        DispatcherTimer timer;

        public MainWindow()
        {
            negocio = new Negocio();
            listaUsuarios = negocio.cargarUsuarios();            
            cont = 0;
            InitializeComponent();
            timer = new DispatcherTimer();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 5);

            timer.Tick += Timer_Tick;
            if (txtNombre.Text == "" || txtContr.Text == "")
            {                
                lblResult.Content = "Introduzca usuario y contraseña";                
                txtNombre.Text = "";
                txtContr.Text = "";
                txtNombre.Focus();
                timer.Start();
            }
            else
            {
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (txtNombre.Text == listaUsuarios[i].usuario
                    && txtContr.Text == listaUsuarios[i].contrasenia)
                    {
                        string nombre = listaUsuarios[i].nombre;
                        int id = listaUsuarios[i].idUsuario;
                        //principal = new Principal(nombre);
                        Hide();
                        //principal.Show();
                    }
                    else
                    {
                        lblResult.Content = "Usuario o contraseña incorrectos";
                        txtNombre.Text = "";
                        txtContr.Text = "";
                        txtNombre.Focus();
                        timer.Start();
                    }

                    cont++;
                    Console.WriteLine("contador " + cont);
                    if (cont >= 3)
                        Close();
                } 
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblResult.Content = "";
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
