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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }
        #region "Variables"
        int id_almacen;
        #endregion

        #region "Funciones"
        private void estidloAlmacen()
        {
            dataAlmacen.Columns[0].Visible = false;
        }
        private void mostrarAlmacen()
        {
            DataTable data = new DataTable();
            D_almacen funcion = new D_almacen();
            funcion.MostrarAlmacen(ref data);
            dataAlmacen.DataSource = data;

            estidloAlmacen();
        }
        private void insertarAlmacen()
        {
            D_almacen funcion = new D_almacen();
            L_almacen parametro = new L_almacen();
            parametro.descripcion = txtDescripcionAlmacen.Text;
            if (funcion.InsertaAlmacen(parametro) == true)
            {
                mostrarAlmacen();
                tabPrincipalAlmacen.SelectedIndex = 0;
            }
        }
        private void ActualizarAlmacen()
        {
            D_almacen funcion = new D_almacen();
            L_almacen parametro = new L_almacen();
            parametro.id_almacen = id_almacen;
            parametro.descripcion = txtDescripcionAlmacen.Text;
            if (funcion.ActualizarAlmacen(parametro) == true)
            {
                mostrarAlmacen();
                tabPrincipalAlmacen.SelectedIndex = 0;
            }
        }
        private void eliminarAlmacen()
        {
            D_almacen funcion = new D_almacen();
            L_almacen parametro = new L_almacen();
            parametro.id_almacen = id_almacen;
            if (funcion.EliminarAlmacen(parametro) == true)
            {
                mostrarAlmacen();
            }
        }
        private void buscarAlmacen()
        {
            DataTable data = new DataTable();
            D_almacen funcion = new D_almacen();
            funcion.BuscarAlmacen(ref data, txtBuscarAlmacen.Text);
            dataAlmacen.DataSource = data;
        }
        #endregion

        private void tabPrincipalAlmacen_Click(object sender, EventArgs e)
        {
            txtDescripcionAlmacen.Enabled = false;

            txtDescripcionAlmacen.Clear();

            txtBuscarAlmacen.Focus();
            txtBuscarAlmacen.Clear();

            btnGuardarAlmacen.Visible = true;
            btnActualizarAlmacen.Visible = false;
            btnVolverAlamcen.Visible = true;

            btnGuardarAlmacen.Enabled = false;
            btnActualizarAlmacen.Enabled = false;
            btnVolverAlamcen.Enabled = true;
        }

        private void btnVolverAlamcen_Click(object sender, EventArgs e)
        {
            tabPrincipalAlmacen.SelectedIndex = 0;
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            txtDescripcionAlmacen.Enabled = true;
            tabPrincipalAlmacen.SelectedIndex = 1;

            btnGuardarAlmacen.Visible = true;
            btnActualizarAlmacen.Visible = false;
            btnVolverAlamcen.Visible = true;

            btnGuardarAlmacen.Enabled = true;
            btnActualizarAlmacen.Enabled = false;
            btnVolverAlamcen.Enabled = true;

            txtDescripcionAlmacen.Focus();
            txtDescripcionAlmacen.Clear();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            mostrarAlmacen();
        }

        private void btnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            if (txtDescripcionAlmacen.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar el Campo Descripcion", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertarAlmacen();
            }
        }

        private void dataAlmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataAlmacen.Columns["Editar"].Index)
            {
                id_almacen = int.Parse(dataAlmacen.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtDescripcionAlmacen.Text = dataAlmacen.Rows[e.RowIndex].Cells[1].Value.ToString();

                tabPrincipalAlmacen.SelectedIndex = 1;

                txtDescripcionAlmacen.Enabled = true;
                txtDescripcionAlmacen.Focus();

                btnGuardarAlmacen.Visible = false;
                btnActualizarAlmacen.Visible = true;
                btnVolverAlamcen.Visible = true;

                btnGuardarAlmacen.Enabled = false;
                btnActualizarAlmacen.Enabled = true;
                btnVolverAlamcen.Enabled = true;
            }
            if (e.ColumnIndex == dataAlmacen.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Quieres Eliminar Este Campo?", "Aviso De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    id_almacen = int.Parse(dataAlmacen.Rows[e.RowIndex].Cells[0].Value.ToString());

                    eliminarAlmacen();
                }
            }
        }

        private void btnActualizarAlmacen_Click(object sender, EventArgs e)
        {
            ActualizarAlmacen();
        }

        private void btnBuscarAlmacen_Click(object sender, EventArgs e)
        {
            buscarAlmacen();
        }
    }
}
