namespace SistemaGestionEF
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

       

        private void frmClientes_Load(object sender, EventArgs e)
        {
            var db = new SistemaGestionContext();

            // Query
            var clientes = db.Clientes
                .OrderBy(b => b.Id)
                .ToList();

            dgClientes.AutoGenerateColumns = true;
            dgClientes.DataSource = clientes;
        }
    }
}