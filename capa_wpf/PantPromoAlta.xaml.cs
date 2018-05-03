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
using Microsoft.Win32;
using System.Drawing;
using capa_entidades;
using System.Windows.Threading;

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantPromoAlta.xaml
    /// </summary>
    public partial class PantPromoAlta : Window
    {
        byte[] fotoArray;
        Negocio n;
        DispatcherTimer timer; 

        public PantPromoAlta(Negocio n)
        {
            InitializeComponent();
            this.n = n;
            timer = new DispatcherTimer();
            txtFechaFin.SelectedDate = DateTime.Now.Date;
            txtFechaIni.SelectedDate = DateTime.Now.Date;
        }

        private void btnImg_Click(object sender, RoutedEventArgs e)
        {
            if (imgPromo.Source == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                BitmapImage myBitmapImage = new BitmapImage();
                openFile.Title = "Seleccione la Imagen de la Promoción";
                openFile.Filter = "Archivos de imagen (*.png; *.jpeg; *.jpg) | *.jpg; *.png; *.jpeg  | Todos los ficheros(*.*) | *.* ";

                if (openFile.ShowDialog() == true)
                {
                    //direccion de la imagen
                    string url_imagen = openFile.FileName;
                    myBitmapImage.BeginInit();
                    myBitmapImage.UriSource = new Uri(openFile.FileName);
                    myBitmapImage.EndInit();
                    imgPromo.Stretch = Stretch.Fill;
                    imgPromo.Source = myBitmapImage;

                    ImageConverter imagen = new ImageConverter();

                    /*public static byte[] converterDemo(Image x)
                    {
                        ImageConverter _imageConverter = new ImageConverter();
                        byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
                        return xByte;
                    }
                    */
                    //fotoArray.ToArray();
                    fotoArray = (byte[])imagen.ConvertTo(System.Drawing.Image.FromFile(url_imagen), typeof(byte[]));
                }
            }
        }

        private void btnPromo_Click(object sender, RoutedEventArgs e)
        {
            DateTime fechaIni = txtFechaIni.SelectedDate.Value.Date;
            DateTime fechaFin = txtFechaFin.SelectedDate.Value.Date;
            string nombre = txtNombre.Text;
            byte[] foto = fotoArray;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick;

            if (foto == null || nombre.Equals(""))
            {
                lblInfo.Foreground = new SolidColorBrush(Colors.Red);
                lblInfo.Content = "Faltan opciones por rellenar";
                timer.Start();
            }
            else
            {
                Promocion promo = new Promocion(nombre, fechaIni, fechaFin, foto);
                int number = n.publicarPromocion(promo);
                
                if (number == 1)
                {
                    //promocion publicada
                    lblInfo.Content = "Promoción publicada";
                    lblInfo.Foreground = new SolidColorBrush(Colors.Blue);
                    timer.Start();
                }
                else
                {
                    //error al publicar la promocion
                    lblInfo.Content = "Error al publicar la promición";
                    lblInfo.Foreground = new SolidColorBrush(Colors.Red);
                    timer.Start();
                }               
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblInfo.Content = "";
        }
    }
}
