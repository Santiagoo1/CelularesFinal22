using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocios;

namespace CelularesFinal2
{
    public partial class Form1 : Form
    {
        Celulares NuevoCelular;
        Celulares CelularExistente;
        NegCelulares objNegCelulares = new NegCelulares();


        public Form1()
        {
            InitializeComponent();
            CrearDGV();
            LlenarDGV();
        }

        private void LlenarDGV()
        {
            DgvCelulares.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegCelulares.listadoCelulares("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvCelulares.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3],
                        dr[4].ToString(), dr[5].ToString(),
                        dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay datos cargados en el sistema");
            }
        }

        private void CrearDGV()
        {
            DgvCelulares.Columns.Add("0", "Codigo");
            DgvCelulares.Columns.Add("1", "Marca");
            DgvCelulares.Columns.Add("2", "Modelo");
            DgvCelulares.Columns.Add("3", "Reparacion");
            DgvCelulares.Columns.Add("4", "Estado");
            DgvCelulares.Columns.Add("5", "DNI_Tecnico");
            DgvCelulares.Columns.Add("6", "Costo_}total");
            DgvCelulares.Columns.Add("7", "Fecha_Ingreso");
            DgvCelulares.Columns.Add("8", "Fecha_Egreso");


            DgvCelulares.Columns[0].Width = 100;
            DgvCelulares.Columns[1].Width = 100;
            DgvCelulares.Columns[2].Width = 100;
            DgvCelulares.Columns[3].Width = 100;
            DgvCelulares.Columns[4].Width = 100;
            DgvCelulares.Columns[5].Width = 100;
            DgvCelulares.Columns[6].Width = 100;
            DgvCelulares.Columns[7].Width = 100;
            DgvCelulares.Columns[8].Width = 100;




        }

        private void LimpiarCelulares()
        {
            txtCodigo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtReparacion.Text = string.Empty;
            txtEstado.Text = string.Empty;
            cbTecnico.Text = string.Empty;
            txtCosto_Total.Text = string.Empty;
            txtFecha_Ingreso.Text = string.Empty;
            txtFecha_Egreso.Text = string.Empty;
        }

        private void btCargarActualizacion_Click(object sender, EventArgs e)
        {

        }

        private void EliminarCelular_Click(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void btCargarCelular_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCargarCelular_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            NuevoCelular = new Celulares(int.Parse(txtCodigo.Text), txtMarca.Text, txtModelo.Text, txtReparacion.Text, txtEstado.Text,int.Parse(cbTecnico.Text), int.Parse(txtCosto_Total.Text), txtFecha_Ingreso.Text, txtFecha_Egreso.Text);

            nGrabados = objNegCelulares.abmCelulares("Alta", NuevoCelular);

            if (nGrabados == -1)
                Mensaje.Text = " No se pudieron cargar los celulares en el sistema";
            else
            {
                Mensaje.Text = " Se cargaron los celulares con éxito";
                LlenarDGV();
                LimpiarCelulares();



            }

        }





        private void btCargarActualizacion_Click_1(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Mensaje_Click(object sender, EventArgs e)
        {

        }
    }
}

