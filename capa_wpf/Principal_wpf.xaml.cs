﻿using System;
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
    /// Lógica de interacción para Principal_wpf.xaml
    /// </summary>
    public partial class Principal_wpf : Window
    {
        MainWindow mWindow;
        Negocio n;

        public Principal_wpf(string nombre, Negocio neg)
        {
            InitializeComponent();
            mWindow = new MainWindow();
            n = neg;
            lblUsuario.Content += nombre;
        }

        private void MenuItem_Click_Salir(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Cliente Twitter",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                mWindow.Show();
                Close();
            }
        }

        private void MenuItem_Click_Todos(object sender, RoutedEventArgs e)
        {
            PantFollowTodos tFollow = new PantFollowTodos(n);
            //this.Hide();
            tFollow.Show();
        }

        private void MenuItem_Click_NoSigo(object sender, RoutedEventArgs e)
        {
            PantFollowNoSigo noFollow = new PantFollowNoSigo(n);
            //this.Hide();
            noFollow.Show();
        }

        private void MenuItem_Click_NoMeSiguen(object sender, RoutedEventArgs e)
        {
            PantFollowNoMeSiguen noFollowers = new PantFollowNoMeSiguen(n);
            //Hide();
            noFollowers.Show();
        }

        private void MenuItem_Click_Recibir(object sender, RoutedEventArgs e)
        {
            PantMencRecibir pRec = new PantMencRecibir(n);
            //Hide();
            pRec.Show();
        }

        private void MenuItem_Click_GestMen(object sender, RoutedEventArgs e)
        {
            PantMencGestion pMGest = new PantMencGestion(n);
            //Hide();
            pMGest.Show();
        }

        private void MenuItem_Click_Eliminar(object sender, RoutedEventArgs e)
        {
            PantMencEliminar pElim = new PantMencEliminar();
            //Hide();
            pElim.Show();
        }

        private void MenuItem_Click_Alta(object sender, RoutedEventArgs e)
        {
            PantPromoAlta pAlta = new PantPromoAlta(n);
            //Hide();
            pAlta.Show();
        }

        private void MenuItem_Click_GestPromo(object sender, RoutedEventArgs e)
        {
            PantPromoGestion pPGest = new PantPromoGestion();
            //Hide();
            pPGest.Show();
        }
    }               
}
