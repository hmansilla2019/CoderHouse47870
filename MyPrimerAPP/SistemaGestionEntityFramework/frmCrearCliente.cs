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
    public partial class frmCrearCliente : Form
    {
        public frmCrearCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var cliente = new Cliente
                {
                    NombreApellido = txtNombreApellido.Text,
                    Domicilio = txtDomicilio.Text,
                    Telefono = txtTelefono.Text
                };

                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
    }
}
