using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }
        private Producto _producto;
        public frmEliminarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
            this.txtDescripcion.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numPrecio.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Contexto.EliminarProducto(_producto);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
