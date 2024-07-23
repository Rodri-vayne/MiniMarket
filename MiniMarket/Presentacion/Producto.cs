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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        #region "Variables"
        int id_marca;
        int id_producto;
        int id_medida;
        int id_categoria;
        #endregion

        #region "Funciones Marca, Categoria, Medida a Producto"
        private void estiloDeMarcayProducto()
        {
            dataMarcaP.Columns[0].Visible = false;
            dataMarcaP.Columns[1].HeaderText = "MARCA";
            
           
        }
        private void mostrarMarcayProducto()
        {
            DataTable datam = new DataTable();
            D_producto funcion = new D_producto();
            funcion.MostrarMarcayProducto(ref datam, txtBuscarMarcaP.Text);
            dataMarcaP.DataSource = datam;
            estiloDeMarcayProducto();
        }
        private void estiloCategoriayProducto()
        {
            dataCategoriaP.Columns[0].Visible = false;
            dataCategoriaP.Columns[1].HeaderText = "CATEGORIA";
            txtBuscarCategoriaP.Clear();
            txtBuscarCategoriaP.Focus();
        }
        private void mostrarCategoriayProducto()
        {
            DataTable datac = new DataTable();
            D_producto funcion = new D_producto();
            funcion.MostrarCategoriayProducto(ref datac, txtBuscarCategoriaP.Text);
            dataCategoriaP.DataSource = datac;
            estiloCategoriayProducto();
        }
        private void estiloUnidadMedidayProducto()
        {
            dataMedidaP.Columns[0].Visible = false;
            dataMedidaP.Columns[1].HeaderText = "UNIDAD MEDIDA";
            txtBuscarUnidadMedidaP.Clear();
            txtBuscarUnidadMedidaP.Focus();
        }
        private void mostrarUnidadMedidayProduto()
        {
            DataTable datau = new DataTable();
            D_producto funcion = new D_producto();
            funcion.MostrarUnidadMedidayProducto(ref datau, txtBuscarUnidadMedidaP.Text);
            dataMedidaP.DataSource = datau;
            estiloUnidadMedidayProducto();
        }
        #endregion
       
        #region "Funciones Producto"
        private void estiloTabla()
        {
            dataProducto.Columns[2].Visible = false;
            dataProducto.Columns[3].HeaderText = "PRODUCTO";
            dataProducto.Columns[4].HeaderText = "MARCA";
            dataProducto.Columns[5].HeaderText = "UNIDADES MEDIDA";
            dataProducto.Columns[6].HeaderText = "CATEGORIA";
            dataProducto.Columns[7].HeaderText = "STOCK MINIMO";
            dataProducto.Columns[8].HeaderText = "STOCK MAXIMO";
            dataProducto.Columns[9].Visible = false;
            dataProducto.Columns[10].Visible = false;
            dataProducto.Columns[11].Visible = false;
        }
        private void mostrarProducto()
        {
            DataTable data = new DataTable();
            D_producto funcion = new D_producto();
            funcion.MostrarProducto(ref data, txtBuscarProducto.Text);
            dataProducto.DataSource = data;

            estiloTabla();
        }
        private void insertarProducto()
        {
            D_producto funcion = new D_producto();
            L_producto parametro = new L_producto();
            parametro.descripcion = txtProducto.Text;
            parametro.id_marca = id_marca;
            parametro.id_medida = id_medida;
            parametro.id_categoria = id_categoria;
            parametro.stock_minimo = Convert.ToDouble(txtStockMinimo.Text);
            parametro.stock_maximo = Convert.ToDouble(txtStockMaximo.Text);
            if (funcion.InsertarProducto(parametro) == true)
            {
                mostrarProducto();
                tabPrincipalProducto.SelectedIndex = 0;
            }
        }
        private void actualizarProducto()
        {
            D_producto funcion = new D_producto();
            L_producto parametro = new L_producto();
            parametro.id_producto = id_producto;
            parametro.descripcion = txtProducto.Text;
            parametro.id_marca = id_marca;
            parametro.id_medida = id_medida;
            parametro.id_categoria = id_categoria;
            parametro.stock_minimo = Convert.ToDouble(txtStockMinimo.Text);
            parametro.stock_maximo = Convert.ToDouble(txtStockMaximo.Text);
            if (funcion.ActualizarProducto(parametro) == true)
            {
                mostrarProducto();
                tabPrincipalProducto.SelectedIndex = 0;
            }
        }
        private void eliminarProducto()
        {
            D_producto funcion = new D_producto();
            L_producto parametro = new L_producto();
            parametro.id_producto = id_producto;
            if (funcion.EliminarProducto(parametro) == true)
            {
                mostrarProducto();
            }
        }
        #endregion

        private void tabPrincipalProducto_Click(object sender, EventArgs e)
        {

            txtProducto.Enabled = false;
            txtMarca.Enabled = false;
            txtMedida.Enabled = false;
            txtCategoria.Enabled = false;
            txtStockMinimo.Enabled = false;
            txtStockMaximo.Enabled = false;

            txtProducto.Clear();
            txtMarca.Clear();
            txtMedida.Clear();
            txtCategoria.Clear();
            txtStockMinimo.Clear();
            txtStockMaximo.Clear();


            btnGuardarProducto.Visible = true;
            btnActualizarProducto.Visible = false;
            btnVolverProducto.Visible = true;

            btnGuardarProducto.Enabled = false;
            btnActualizarProducto.Enabled = false;
            btnVolverProducto.Enabled = true;

            btnTablaMarca.Enabled = false;
            btnTablaMedida.Enabled = false;
            btnTablaCategoria.Enabled = false;
        }

        private void btnVolverProducto_Click(object sender, EventArgs e)
        {
            tabPrincipalProducto.SelectedIndex = 0;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            tabPrincipalProducto.SelectedIndex = 1;

            txtProducto.Focus();
            txtBuscarProducto.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtMedida.Clear();
            txtCategoria.Clear();
            txtStockMinimo.Clear();
            txtStockMaximo.Clear();

            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnGuardarProducto.Visible = true;
            btnActualizarProducto.Visible = false;
            btnVolverProducto.Visible = true;

            btnGuardarProducto.Enabled = true;
            btnActualizarProducto.Enabled = false;
            btnVolverProducto.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            mostrarProducto();
            mostrarMarcayProducto();
            mostrarCategoriayProducto();
            mostrarUnidadMedidayProduto();

        
        }

        private void btnTablaMarca_Click(object sender, EventArgs e)
        {
            panelTablaMarcaP.Location = btnTablaMarca.Location;
            panelTablaMarcaP.Visible = true;

            txtProducto.Enabled = false;
            txtMarca.Enabled = true;
            txtMedida.Enabled = false;
            txtCategoria.Enabled = false;
            txtStockMinimo.Enabled = false;
            txtStockMaximo.Enabled = false;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = false;
            btnTablaCategoria.Enabled = false;
        }

        private void btnVolverMarcaP_Click(object sender, EventArgs e)
        {
           
            panelTablaMarcaP.Visible = false;

            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void dataMarcaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_marca = int.Parse(dataMarcaP.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtMarca.Text = dataMarcaP.Rows[e.RowIndex].Cells[1].Value.ToString();

            panelTablaMarcaP.Visible = false;

            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }
        private void dataMedidaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_medida = int.Parse(dataMedidaP.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtMedida.Text = dataMedidaP.Rows[e.RowIndex].Cells[1].Value.ToString();

            panelUnidadMedidaP.Visible = false;

            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void dataCategoriaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_categoria = int.Parse(dataCategoriaP.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtCategoria.Text = dataCategoriaP.Rows[e.RowIndex].Cells[1].Value.ToString();

            panelCategoriaP.Visible = false;

            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void btnTablaMedida_Click(object sender, EventArgs e)
        {
            panelUnidadMedidaP.Location = btnTablaMedida.Location;
            panelUnidadMedidaP.Visible = true;

            txtProducto.Enabled = false;
            txtMarca.Enabled = false;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = false;
            txtStockMinimo.Enabled = false;
            txtStockMaximo.Enabled = false;

            btnTablaMarca.Enabled = false;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = false;
        }

        private void btnTablaCategoria_Click(object sender, EventArgs e)
        {
            panelCategoriaP.Location = btnTablaCategoria.Location;
            panelCategoriaP.Visible = true;

            txtProducto.Enabled = false;
            txtMarca.Enabled = false;
            txtMedida.Enabled = false;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = false;
            txtStockMaximo.Enabled = false;

            btnTablaMarca.Enabled = false;
            btnTablaMedida.Enabled = false;
            btnTablaCategoria.Enabled = true;
        }

        private void btnVolverUnidadMedida_Click(object sender, EventArgs e)
        {
            panelUnidadMedidaP.Visible = false;
            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void btnVolverCategoriaP_Click(object sender, EventArgs e)
        {
            panelCategoriaP.Visible = false;
            txtProducto.Enabled = true;
            txtMarca.Enabled = true;
            txtMedida.Enabled = true;
            txtCategoria.Enabled = true;
            txtStockMinimo.Enabled = true;
            txtStockMaximo.Enabled = true;

            btnTablaMarca.Enabled = true;
            btnTablaMedida.Enabled = true;
            btnTablaCategoria.Enabled = true;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Producto", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Marca", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMedida.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Unidad De Meidad", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCategoria.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Categoria", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStockMinimo.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Stock Minimo", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStockMaximo.Text == string.Empty)
            {
                MessageBox.Show("Falta Llenar El Campo Stock Maximo", "Aviso De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertarProducto();
            }
        }

        private void dataProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataProducto.Columns["Editar"].Index)
            {
                id_producto = int.Parse(dataProducto.Rows[e.RowIndex].Cells[2].Value.ToString());

                txtProducto.Text = dataProducto.Rows[e.RowIndex].Cells[3].Value.ToString();

                txtMarca.Text = dataProducto.Rows[e.RowIndex].Cells[4].Value.ToString();

                txtMedida.Text = dataProducto.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtCategoria.Text = dataProducto.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtStockMinimo.Text = dataProducto.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtStockMaximo.Text = dataProducto.Rows[e.RowIndex].Cells[8].Value.ToString();

                tabPrincipalProducto.SelectedIndex = 1;

                txtProducto.Enabled = true;
                txtMarca.Enabled = true;
                txtMedida.Enabled = true;
                txtCategoria.Enabled = true;
                txtStockMinimo.Enabled = true;
                txtStockMaximo.Enabled = true;

                btnTablaMarca.Enabled = true;
                btnTablaMedida.Enabled = true;
                btnTablaCategoria.Enabled = true;

                btnGuardarProducto.Visible = false;
                btnActualizarProducto.Visible = true;
                btnVolverProducto.Visible = true;

                btnGuardarProducto.Enabled = false;
                btnActualizarProducto.Enabled = true;
                btnVolverProducto.Enabled = true;
            }
            if (e.ColumnIndex == dataProducto.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Quieres Eliminar Este Campo Producto?", "Aviso De Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.OK)
                {
                    id_producto = int.Parse(dataProducto.Rows[e.RowIndex].Cells[2].Value.ToString());

                    eliminarProducto();
                }
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            actualizarProducto();
        }

        private void btnBuscarMarcaP_Click(object sender, EventArgs e)
        {
            mostrarMarcayProducto();
        }

        private void btnUnidadMedidaP_Click(object sender, EventArgs e)
        {
            mostrarUnidadMedidayProduto();
        }

        private void btnBuscarCategoriaP_Click(object sender, EventArgs e)
        {
            mostrarCategoriayProducto();
        }

    }
}
