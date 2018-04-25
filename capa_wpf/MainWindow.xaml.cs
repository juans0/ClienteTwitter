using System;
using System.Collections.Generic;
using System.Windows;
using capa_negocio;
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
        Principal_wpf wpfPr;

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
            if (txtNombre.Text == "" || txtContr.Password == "")
            {                
                lblResult.Content = "Introduzca usuario y contraseña";                
                txtNombre.Text = "";
                txtContr.Password = "";
                txtNombre.Focus();
                timer.Start();
                
            }
            else
            {
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (txtNombre.Text == listaUsuarios[i].usuario
                    && txtContr.Password == listaUsuarios[i].contrasenia)
                    {
                        string nombre = listaUsuarios[i].nombre;
                        int id = listaUsuarios[i].idUsuario;
                        wpfPr = new Principal_wpf(nombre);
                        Hide();
                        wpfPr.Show();
                        return;
                    }
                    else
                    {
                        lblResult.Content = "Usuario o contraseña incorrectos";
                        txtNombre.Text = "";
                        txtContr.Password = "";
                        txtNombre.Focus();
                        timer.Start();
                    }                    
                }
                cont++;
                Console.WriteLine("contador " + cont);
                if (cont >= 3)
                    Close();
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
