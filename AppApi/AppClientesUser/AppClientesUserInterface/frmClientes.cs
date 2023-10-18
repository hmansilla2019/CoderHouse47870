using AppClientesEntities;
using AppClientesBussiness;
using System.Net.Http;
using System.Net.Http.Json;

namespace AppClientesUserInterface
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            filtrarAsync();
         

        }

        private async Task filtrarAsync()
        {
            HttpClient client = new HttpClient();
            // List<Cliente> clientes = ClienteBussiness.GetClientes();

            List<Cliente>? list = null;
            try
            {
                string path = @"https://localhost:7020/api/Clientes";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Cliente>>();
                    dgClientes.AutoGenerateColumns = true;
                    dgClientes.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de comunicacion con la API");
            }



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCrearCliente cliente = new frmCrearCliente();
            cliente.FormClosed += Cliente_FormClosed;
            cliente.ShowDialog();
        }
        private void Cliente_FormClosed(object? sender, FormClosedEventArgs e)
        {
            filtrarAsync();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int codigo = (int)this.dgClientes.Rows[e.RowIndex].Cells["Id"].Value;

                frmModificarCliente frmModificarCliente = new frmModificarCliente(codigo);
                frmModificarCliente.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Cliente_FormClosed);

                frmModificarCliente.ShowDialog();
            }

            if (this.dgClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int codigo = (int)this.dgClientes.Rows[e.RowIndex].Cells["Id"].Value;

                frmEliminarCliente frmEliminarCliente = new frmEliminarCliente(codigo);
                frmEliminarCliente.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Cliente_FormClosed);

                frmEliminarCliente.ShowDialog();
            }
        }
    }
}