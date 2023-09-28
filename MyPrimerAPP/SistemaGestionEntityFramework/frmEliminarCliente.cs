using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayoristaEstrellaUI
{
    public partial class frmEliminarCliente : Form
    {
        private Cliente cliente;
       
        public frmEliminarCliente(int IDCliente)
        {
            InitializeComponent();

            this.cliente = new Cliente();

            var db = new SistemaGestionContext();

            // Query
            this.cliente = db.Clientes.Where(x => x.Id.Equals(IDCliente)).SingleOrDefault();
            txtDomicilio.Text = cliente.Domicilio;
            txtNombreApellido.Text = cliente.NombreApellido;
            txtTelefono.Text = cliente.Telefono;
        }

        public frmEliminarCliente()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var cliente = context.Clientes.Where(x => x.Id.Equals(this.cliente.Id)).Single();

                context.Remove(cliente);
                context.SaveChanges();
            }
        }

        private void frmEliminarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
