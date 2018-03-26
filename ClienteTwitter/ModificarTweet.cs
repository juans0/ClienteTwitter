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
    public partial class ModificarTweet : Form
    {
        private Negocio negocio;
        private List<TweetProgramado> lista;
        private DataTable dataTable;
        private DataView dataView;
        private int tiempo;

        public ModificarTweet(Negocio n)
        {
            negocio = n;
            InitializeComponent();
            rBtnTodos.Checked = true;
            dataGrid.Select();
            lista = negocio.cargarTweetsProgramados();
            crearDataGrid();
            cargarListaTweets();
            tiempo = 0;
        }

        public void crearDataGrid()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("ID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Fecha", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Texto", typeof(string)));

            dataView = new DataView(dataTable);
            dataGrid.DataSource = dataView;           
        }

        //Filtra por texto introducido
        private void txtTexto_TextChanged(object sender, EventArgs e)
        {           
            if (txtTexto.Text != "")
                filtrarFecha("Texto", txtTexto.Text);
            else
            {
                crearDataGrid();
                cargarListaTweets();
            }
        }

        //Carga los tweets en el datgrid
        public void cargarListaTweets()
        {
            try
            {
                dataTable.Clear();

                for (int i = 0; i < lista.Count; i++)                                        
                {
                    string fecha = lista[i].fechaProgramacion;

                    string f = fecha.Substring(0, 4) +
                    "/" + fecha.Substring(4, 2) + "/" +
                    fecha.Substring(6, 2) + " " + 
                    fecha.Substring(8, 2) + ":" + 
                    fecha.Substring(10, 2);

                    DataRow row = dataTable.NewRow();

                    row["ID"] = lista[i].id;
                    row["Fecha"] = f;
                    row["Texto"] = lista[i].titulo;
                    
                    dataTable.Rows.Add(row);

                    row.AcceptChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        //Carga los datos de la celda seleccionada en los textBox
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFechaAntiguo.Text =
                this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtTweetAntiguo.Text = 
                this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtFechaNuevo.Text =
                this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtTweetNuevo.Text =
                this.dataGrid.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (txtFechaAntiguo.Text.Equals("") || txtTweetAntiguo.Text.Equals(""))
            {
                barraStatus.ForeColor = Color.Red;
                toolSLabel.Text = "Seleccione tweet";
            }
            else if (txtFechaNuevo.Text.Equals("") || txtTweetNuevo.Text.Equals(""))
            {
                barraStatus.ForeColor = Color.Red;
                toolSLabel.Text = "Introduzca fecha y texto de modificación";
            }
            else
            {
                if (MessageBox.Show("¿Modificar tweet?", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {                    
                    string[] arrayFecha = txtFechaNuevo.Text.Split('/', ' ', ':');
                    string fecha = arrayFecha[0] + arrayFecha[1] + arrayFecha[2]
                        + arrayFecha[3] + arrayFecha[4];
                     
                    int respuesta = negocio.modificarTweetProgramado(
                        Convert.ToInt32(dataGrid.CurrentRow.Cells[0].Value),
                        txtTweetNuevo.Text, fecha);
                    if (respuesta != 0)
                    {
                        barraStatus.ForeColor = Color.Blue;
                        toolSLabel.Text = "Tweet modificado";
                        lista = negocio.cargarTweetsProgramados();
                        cargarListaTweets();                       
                    }

                    else
                    {
                        barraStatus.ForeColor = Color.Red;
                        toolSLabel.Text = "Error al modificar el tweet";
                    }
                    txtTweetNuevo.Text = "";
                    txtTweetAntiguo.Text = "";
                    txtFechaNuevo.Text = "";
                    txtFechaAntiguo.Text = "";
                }                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;     
            if (tiempo >= 4)
            {
                toolSLabel.Text = "";
                timer1.Stop();
                tiempo = 0;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (txtFechaAntiguo.Text.Equals("") || txtTweetAntiguo.Text.Equals(""))
            {
                barraStatus.ForeColor = Color.Red;
                toolSLabel.Text = "Seleccione tweet";
            }
            else
            {
                if (MessageBox.Show("¿Eliminar tweet?", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {                    
                    int respuesta = negocio.eliminarTweetProgramado(
                        Convert.ToInt32(dataGrid.CurrentRow.Cells[0].Value));
                    if (respuesta != 0)
                    {
                        barraStatus.ForeColor = Color.Blue;
                        toolSLabel.Text = "Tweet eliminado";
                        lista = negocio.cargarTweetsProgramados();
                        cargarListaTweets();
                    }
                    else
                    {
                        barraStatus.ForeColor = Color.Red;
                        toolSLabel.Text = "Error al eliminar el tweet";
                    }
                    txtTweetNuevo.Text = "";
                    txtTweetAntiguo.Text = "";
                    txtFechaNuevo.Text = "";
                    txtFechaAntiguo.Text = "";
                }
            }
        }

        private void ModificarTweet_Load(object sender, EventArgs e)
        {

        }

        private void rBtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            lista = negocio.cargarTweetsProgramados();
            crearDataGrid();
            cargarListaTweets();
            dataGrid.Focus();
            txtTexto.Text = "";
        }

        private void rBtnTexto_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.Focus();
        }

        private void rBtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            string[] fecha = monthCalendar1.SelectionRange.Start.ToShortDateString().Split('/');            
            string fecha2 = fecha[2] + "/" + fecha[1] + "/" + fecha[0];

            filtrarFecha("Fecha", fecha2);
                            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!rBtnFecha.Checked)
                rBtnFecha.Checked = true;        
            string[] fecha = monthCalendar1.SelectionRange.Start.ToShortDateString().Split('/');
            string fecha2 = fecha[2] + "/" + fecha[1] + "/" + fecha[0];

            filtrarFecha("Fecha", fecha2);
           
        }

        private void filtrarFecha(string tipo, string texto)
        {            
            dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("ID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Fecha", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Texto", typeof(string)));

            cargarListaTweets();

            try
            {
                DataTable datFilt = dataTable.Copy();

                for (int i = datFilt.Rows.Count - 1; i >= 0; i--)
                {
                    if (!datFilt.Rows[i][tipo].ToString().Contains(texto))
                    {
                        datFilt.Rows.RemoveAt(i);
                    }
                }

                dataView = new DataView(datFilt);
                dataGrid.DataSource = dataView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
