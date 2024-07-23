using MiniMarket.Datos;
using MiniMarket.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniMarket.Presentacion
{
    public partial class UnidadesMedidas : Form
    {
        public UnidadesMedidas()
        {
            InitializeComponent();
        }
        #region "Variable"
        int id_medida;
        #endregion
        #region "Funciones Medida"

        private void ocultarIdMedida()
        {
            dataMedida.Columns[0].Visible = false;
        }
        private void mostrarMedida()
        {
            D_medida funcion = new D_medida();
            DataTable data = new DataTable();
            funcion.MostrarMedia(ref data);
            dataMedida.DataSource = data;

            ocultarIdMedida();
        }

        private void insertarMedia()
        {
            D_medida funcion = new D_medida();
            L_medida parametro = new L_medida();
            parametro.abreviatura = txtAbreviaturaMedida.Text;
            parametro.descripcion = txtDescripcionMedida.Text;
            if (funcion.InsertarMedida(parametro) == true)
            {
                mostrarMedida();

                tabPrincipalMedida.SelectedIndex = 0;
            }
        }

        private void actualizarMedida()
        {
            D_medida funcion = new D_medida();
            L_medida parametro = new L_medida();
            parametro.id_medida = id_medida;
            parametro.abreviatura = txtAbreviaturaMedida.Text;
            parametro.descripcion = txtDescripcionMedida.Text;
            if (funcion.ActualizarMedia(parametro) == true)
            {
                mostrarMedida();
                tabPrincipalMedida.SelectedIndex = 0;
            }
        }

        private void eliminarMedida()
        {
            L_medida parametro = new L_medida();
            D_medida funcion = new D_medida();
            parametro.id_medida = id_medida;
            if (funcion.EliminarMarca(parametro) == true)
            {
                mostrarMedida();
            }
        }

        private void buscarMedida()
        {
            D_medida funcion = new D_medida();
            DataTable data = new DataTable();
            funcion.BuscarMedida(ref data, txtBuscarMedida.Text);
            dataMedida.DataSource = data;
        }
        #endregion

        private void UnidadesMedidas_Load(object sender, EventArgs e)
        {
            mostrarMedida();
        }

        private void tabPrincipalMedida_Click(object sender, EventArgs e)
        {
            txtBuscarMedida.Focus();
            txtBuscarMedida.Clear();

            txtDescripcionMedida.Enabled = false;
            txtAbreviaturaMedida.Enabled = false;

            txtDescripcionMedida.Clear();

            btnGuardarMedida.Visible = true;
            btnActualizarMedida.Visible = false;
            btnVolverMedida.Visible = true;

            btnGuardarMedida.Enabled = false;
            btnActualizarMedida.Enabled = false;
            btnVolverMedida.Enabled = true;
        }

        private void btnVolverMedida_Click(object sender, EventArgs e)
        {
            tabPrincipalMedida.SelectedIndex = 0;
            txtBuscarMedida.Clear();
        }

        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            txtAbreviaturaMedida.Focus();
            txtAbreviaturaMedida.Clear();
            txtDescripcionMedida.Clear();
            txtDescripcionMedida.Enabled = true;
            txtAbreviaturaMedida.Enabled = true;


            btnGuardarMedida.Visible = true;
            btnActualizarMedida.Visible = false;
            btnVolverMedida.Visible = true;

            btnGuardarMedida.Enabled = true;
            btnActualizarMedida.Enabled = false;
            btnVolverMedida.Enabled = true;

            tabPrincipalMedida.SelectedIndex = 1;
        }

        private void btnGuardarMedida_Click(object sender, EventArgs e)
        {
            if (txtAbreviaturaMedida.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Abreviatura", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescripcionMedida.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Descripcion", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertarMedia();
            }
        }

        private void dataMedida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataMedida.Columns["Editar"].Index)
            {
                id_medida = int.Parse(dataMedida.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtAbreviaturaMedida.Text = dataMedida.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtDescripcionMedida.Text = dataMedida.Rows[e.RowIndex].Cells[2].Value.ToString();

                tabPrincipalMedida.SelectedIndex = 1;

                txtDescripcionMedida.Enabled = true;
                txtAbreviaturaMedida.Enabled = true;

                btnGuardarMedida.Visible = false;
                btnActualizarMedida.Visible = true;
                btnVolverMedida.Visible = true;

                btnGuardarMedida.Enabled = false;
                btnActualizarMedida.Enabled = true;
                btnVolverMedida.Enabled = true;
            }
            if (e.ColumnIndex == dataMedida.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Quieres Eliminar Esta Medida?", "Aviso De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    id_medida = int.Parse(dataMedida.Rows[e.RowIndex].Cells[0].Value.ToString());

                    eliminarMedida();
                }
            }
        }

        private void btnActualizarMedida_Click(object sender, EventArgs e)
        {
            actualizarMedida();
        }

        private void btnBuscarMedida_Click(object sender, EventArgs e)
        {
            buscarMedida();
        }
    }
}
