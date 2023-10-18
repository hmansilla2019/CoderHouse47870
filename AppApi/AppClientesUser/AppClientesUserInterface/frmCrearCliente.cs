
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClientesUserInterface
{
    public partial class frmCrearCliente : Form
    {
        public frmCrearCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.NombreApellido = txtNombreApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Domicilio = txtDomicilio.Text;
            AltaCliente(cliente);
           
        }
        private  async Task<bool> AltaCliente(Cliente cliente)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7020/api/Clientes";
           
            HttpResponseMessage response = await client.PostAsJsonAsync(
            path, cliente);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Se dio de alta correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar dar de alta");
                return false;
            }
        }
        private void frmCrearCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
