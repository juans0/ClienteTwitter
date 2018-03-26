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
    public partial class UsuariosApp : Form
    {
        private Negocio negocio;
        private List<UserApp> listaUsuarios;

        public UsuariosApp(Negocio negocio)
        {
            InitializeComponent();
            this.negocio = negocio;
            listaUsuarios = negocio.cargarUsuarios();
            //crearUsuarios();
            cargarUsuarios();
        }

        public void cargarUsuarios()
        {
            listaUsuarios = negocio.cargarUsuarios();
            int i = 0;                   

            dataGridUserApp.Rows.Clear();

            while (i < listaUsuarios.Count)
            {
                dataGridUserApp.Rows.Add();
                i++;
            }

            i = 0;
            while (i < listaUsuarios.Count)
            {
                dataGridUserApp.Rows[i].Cells[0].Value = listaUsuarios[i].usuario.ToString();
                dataGridUserApp.Rows[i].Cells[1].Value = listaUsuarios[i].email.ToString();
                dataGridUserApp.Rows[i].Cells[2].Value = listaUsuarios[i].nombre.ToString();
                dataGridUserApp.Rows[i].Cells[3].Value = listaUsuarios[i].apellidos.ToString();
                i++;
            }
        }
    }
}
