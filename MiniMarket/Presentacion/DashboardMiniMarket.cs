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
    public partial class DashboardMiniMarket : Form
    {
        public DashboardMiniMarket()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.ShowDialog();
        }

        private void unidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnidadesMedidas medida = new UnidadesMedidas();
            medida.ShowDialog();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog();
        }
    }
}
