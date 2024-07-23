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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }
        #region "Variable"
        int id_marca;
        #endregion
        #region"Funciones Marca"
        private void ocultarIdMarca()
        {
            dataMarca.Columns[0].Visible = false;
        }
        private void MostrarMarca()
        {
            DataTable data = new DataTable();
            D_marca funcion = new D_marca();
            funcion.MostrarMarca(ref data);
            dataMarca.DataSource = data;

            ocultarIdMarca();
        }

        private void editarMarca()
        {
            D_marca funcion = new D_marca();
            L_marca parametro = new L_marca();
            parametro.id_marca = id_marca;
            parametro.descripcion = txtDescripcionMarca.Text;
            if (funcion.EditarMarca(parametro) == true)
            {
                MostrarMarca();

                tabPrincipalMarca.SelectedIndex = 0;
            }
        }
        private void insertarMarca()
        {
            D_marca funcion = new D_marca();
            L_marca parametro = new L_marca();
            parametro.descripcion = txtDescripcionMarca.Text;
            if (funcion.InsertarMarca(parametro) == true)
            {
                MostrarMarca();
                tabPrincipalMarca.SelectedIndex = 0;
            }
        }

        private void eliminarMarca()
        {
            D_marca funcion = new D_marca();
            L_marca parametro = new L_marca();
            parametro.id_marca = id_marca;
            if (funcion.EliminarMarca(parametro) == true)
            {
                MostrarMarca();
            }
        }

        private void buscarMarca()
        {
            D_marca funcion = new D_marca();
            DataTable data = new DataTable();
            funcion.BuscarMarca(ref data, txtBuscarMarca.Text);
            dataMarca.DataSource = data;
        }
        #endregion

        private void tabPrincipalMarca_Click(object sender, EventArgs e)
        {
            txtBuscarMarca.Focus();
            txtBuscarMarca.Clear();

            txtDescripcionMarca.Enabled = false;

            txtDescripcionMarca.Clear();

            btnGuardarMarca.Visible = true;
            btnActualizarMarca.Visible = false;
            btnVolverMarca.Visible = true;

            btnGuardarMarca.Enabled = false;
            btnActualizarMarca.Enabled = false;
            btnVolverMarca.Enabled = true;
        }

        private void btnVolverMarca_Click(object sender, EventArgs e)
        {
            tabPrincipalMarca.SelectedIndex = 0;
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            MostrarMarca();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            txtDescripcionMarca.Clear();
            txtDescripcionMarca.Focus();

            txtDescripcionMarca.Enabled = true;

            btnGuardarMarca.Visible = true;
            btnActualizarMarca.Visible = false;
            btnVolverMarca.Visible = true;

            btnGuardarMarca.Enabled = true;
            btnActualizarMarca.Enabled = false;
            btnVolverMarca.Enabled = true;

            tabPrincipalMarca.SelectedIndex = 1;
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (txtDescripcionMarca.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Marca", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertarMarca();
            }
        }

        private void dataMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataMarca.Columns["Editar"].Index)
            {
                id_marca = int.Parse(dataMarca.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtDescripcionMarca.Text = dataMarca.Rows[e.RowIndex].Cells[1].Value.ToString();

                tabPrincipalMarca.SelectedIndex = 1;

                txtDescripcionMarca.Enabled = true;

                btnGuardarMarca.Visible = false;
                btnActualizarMarca.Visible = true;
                btnVolverMarca.Visible = true;

                btnGuardarMarca.Enabled = false;
                btnActualizarMarca.Enabled = true;
                btnVolverMarca.Enabled = true;
            }
            if (e.ColumnIndex == dataMarca.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Quieres Eliminar Esta Marca?", "Aviso De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    id_marca = int.Parse(dataMarca.Rows[e.RowIndex].Cells[0].Value.ToString());

                    eliminarMarca();
                }
            }
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            editarMarca();
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            buscarMarca();
        }
       
    }
}
