
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClientesUserInterface
{
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }
        private Cliente cliente;
        private int idCliente;
        public frmModificarCliente(int IDCliente)
        {
            InitializeComponent();
            idCliente = IDCliente;
           
           
            
        }
        private async void CargarDatos()
        {
            HttpClient client = new HttpClient();

            string path = @"https://localhost:7020/api/Clientes";
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadFromJsonAsync<List<Cliente>>();
                this.cliente = list.Where(x => x.Id.Equals(idCliente)).SingleOrDefault();

                txtDomicilio.Text = this.cliente.Domicilio;
                txtNombreApellido.Text = this.cliente.NombreApellido;
                txtTelefono.Text = this.cliente.Telefono;
            }
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.cliente.NombreApellido = txtNombreApellido.Text;
            this.cliente.Telefono = txtTelefono.Text;
            this.cliente.Domicilio = txtDomicilio.Text;
            ModificarCliente(this.cliente);

        }

        private async Task<bool> ModificarCliente(Cliente pcliente)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7020/api/Clientes";

            HttpResponseMessage response = await client.PutAsJsonAsync(
            path, pcliente);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Se modifico correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar modificar el cliente");
                return false;
            }
        }

    }
}
