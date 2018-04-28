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

namespace capa_wpf
{
    /// <summary>
    /// Lógica de interacción para PantFollowNoMeSiguen.xaml
    /// </summary>
    public partial class PantFollowNoMeSiguen : Window
    {
        Negocio n;
                
        public PantFollowNoMeSiguen(Negocio neg)
        {
            InitializeComponent();
            n = neg;
        }
    }
}
