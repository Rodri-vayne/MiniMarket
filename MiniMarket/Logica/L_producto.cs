using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMarket.Logica
{
    public class L_producto
    {
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public int id_marca { get; set; }
        public int id_medida { get; set; }
        public int id_categoria { get; set; }
        public double stock_minimo { get; set; }
        public double stock_maximo { get; set; }
    }
}
