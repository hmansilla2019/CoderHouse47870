
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClientesUserInterface
{
    public partial class frmEliminarCliente : Form
    {
        private Cliente cliente;
        private int idCliente;
        public frmEliminarCliente(int IDCliente)
        {
            InitializeComponent();

            this.idCliente = IDCliente;
        }

        public frmEliminarCliente()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EliminarCliente(this.cliente);
        }

        private void frmEliminarCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
                txtDomicilio.Text = cliente.Domicilio;
                txtNombreApellido.Text = cliente.NombreApellido;
                txtTelefono.Text = cliente.Telefono;
            }
        }


        private async Task<bool> EliminarCliente(Cliente pcliente)
        {
            string path = @"https://localhost:7020/api/Clientes";
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(pcliente.Id),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(path, UriKind.Absolute)
            };
            
                HttpResponseMessage response = await client.SendAsync(
          request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar el cliente");

                return false;
            }
          
          
          
        }
    }
}
