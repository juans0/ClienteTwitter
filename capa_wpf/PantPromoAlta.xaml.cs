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

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantPromoAlta.xaml
    /// </summary>
    public partial class PantPromoAlta : Window
    {
        byte[] fotoArray;
        Negocio n;
        public PantPromoAlta(Negocio n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void btnImg_Click(object sender, RoutedEventArgs e)
        {
            if (imgPromo.Source == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                BitmapImage myBitmapImage = new BitmapImage();
                openFile.Title = "Seleccione la Imagen a Mostrar";
                openFile.Filter = "Image files (*.png; *.jpeg)| *.png; *.jpeg | All files(*.*) | *.* ";

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
            if (foto == null || nombre.Equals(""))
            {
                infoText.Foreground = new SolidColorBrush(Colors.Red);
                infoText.Text = "Faltan opciones por rellenar";
            }
            else
            {
                Promocion promo = new Promocion(nombre, fechaIni, fechaFin, foto);
                int number = n.publicarPromocion(promo);
                string mensaje;
                if (number == 1)
                {
                    //no se ha podido llevar a cabo la promocion
                    mensaje = "No se podido llevar a cabo la introduccion de la promocion";
                    infoText.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    //se ha introducido correctamente la promocion
                    mensaje = "Promocion subida correctamente";
                    infoText.Foreground = new SolidColorBrush(Colors.Blue);
                }
                infoText.Text = mensaje;
            }
        }
    }
}
