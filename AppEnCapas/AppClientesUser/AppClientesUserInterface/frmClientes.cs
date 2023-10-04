using AppClientesEntities;
using AppClientesBussiness;
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
            List<Cliente> clientes = ClienteBussiness.GetClientes();
            dgClientes.AutoGenerateColumns = true;
            dgClientes.DataSource = clientes;
        }
    }
}