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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        #region "Variables"
        int id_categoria;
        #endregion
        #region "Funciones Aparte"

        private void ocultarIdCategoria()
        {
            dataCategoria.Columns[0].Visible = false;
        }
        private void mostrarCategoria()
        {
            DataTable dt = new DataTable();
            D_categoria funcion = new D_categoria();
            funcion.MostrarCategoria(ref dt);
            dataCategoria.DataSource = dt;

            ocultarIdCategoria();
        }

        private void insertarCategoria()
        {
            D_categoria funcion = new D_categoria();
            L_categoria parametro = new L_categoria();
            parametro.descripcion = txtDescripcionCategoria.Text;
            if (funcion.InsertarCategoria(parametro) == true)
            {
                mostrarCategoria();

                tabPrincipalCategoria.SelectedIndex = 0;
            }
        }

        private void actualizarCategoria()
        {
            D_categoria funcion = new D_categoria();
            L_categoria parametro = new L_categoria();
            parametro.id_categoria = id_categoria;
            parametro.descripcion = txtDescripcionCategoria.Text;
            if (funcion.EditarCategoria(parametro) == true)
            {
                btnGuardarCategoria.Visible = false;
                btnActualizarCategoria.Visible = true;
                btnVolverCategoria.Visible = true;

                tabPrincipalCategoria.SelectedIndex = 0;

                mostrarCategoria();
            }
        }

        private void eliminarCategoria()
        {
            D_categoria funcion = new D_categoria();
            L_categoria parametro = new L_categoria();
            parametro.id_categoria = id_categoria;
            if (funcion.EliminarCategoria(parametro) == true)
            {
                mostrarCategoria();
            }
        }

        private void buscarCategoria()
        {
            D_categoria funcion = new D_categoria();
            DataTable data = new DataTable();
            funcion.BuscarCategoria(ref data, txtBuscarCategoria.Text);
            dataCategoria.DataSource = data;
        }
        #endregion

        private void tabPrincipalCategoria_Click(object sender, EventArgs e)
        {
            
            txtDescripcionCategoria.Enabled = false;
            txtDescripcionCategoria.Clear();

            txtBuscarCategoria.Focus();
            txtBuscarCategoria.Clear();

            btnGuardarCategoria.Visible = true;
            btnActualizarCategoria.Visible = false;
            btnVolverCategoria.Visible = true;

            btnGuardarCategoria.Enabled = false;
            btnActualizarCategoria.Enabled = false;
            btnVolverCategoria.Enabled = true;
        }

        private void btnVolverCategoria_Click(object sender, EventArgs e)
        {
            tabPrincipalCategoria.SelectedIndex = 0;
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            mostrarCategoria();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            tabPrincipalCategoria.SelectedIndex = 1;
            txtDescripcionCategoria.Focus();
            txtDescripcionCategoria.Clear();
            txtDescripcionCategoria.Enabled = true;

            btnGuardarCategoria.Visible = true;
            btnActualizarCategoria.Visible = false;
            btnVolverCategoria.Visible = true;

            btnGuardarCategoria.Enabled = true;
            btnActualizarCategoria.Enabled = false;
            btnVolverCategoria.Enabled = true;
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (txtDescripcionCategoria.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Categoria", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertarCategoria();
            }
        }

        private void dataCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataCategoria.Columns["Editar"].Index)
            {
                id_categoria = int.Parse(dataCategoria.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtDescripcionCategoria.Text = dataCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();

                tabPrincipalCategoria.SelectedIndex = 1;

                btnGuardarCategoria.Visible = false;
                btnActualizarCategoria.Visible = true;
                btnVolverCategoria.Visible = true;
                txtDescripcionCategoria.Enabled = true;

                btnGuardarCategoria.Enabled = false;
                btnActualizarCategoria.Enabled = true;
                btnVolverCategoria.Enabled = true;
            }

            if (e.ColumnIndex == dataCategoria.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Quieres Eliminar Esta Categoria?", "Aviso De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.OK)
                {
                    id_categoria = int.Parse(dataCategoria.Rows[e.RowIndex].Cells[0].Value.ToString());

                    eliminarCategoria();
                }
            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            actualizarCategoria();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            buscarCategoria();
        }
    }
}
