namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaMayores mayores;

        private void CargarMayores()
        {
            dgMayores.AutoGenerateColumns = true;
            dgMayores.DataSource = mayores.GetListaMayores().ToList();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            mayores = new ListaMayores();

            Cliente[] clientes =
            {
                new Cliente("Juan Perez", 1234,"Larrea 492",52),
                new Cliente("Luis Perea", 547,"Larrea 492",57),
                new Cliente("Natalia Perez", 487,"Peru 446",85),
                new Cliente("Luisa Garcia", 8545,"Larrea 492",45),
                new Cliente("Alberto Ruiz", 4525,"San Juan 445",57)
            };

            mayores.InsertarEnLista(clientes);
            CargarMayores();


        }

        private void btnMadificar_Click(object sender, EventArgs e)
        {
            Cliente aModificar = new Cliente("Alberto Ruiz", 4525, "San Juan 445", 57);
            Cliente clienteNuevo = new Cliente("Francisto Juares", 4525, "San Diego 434", 45);
            mayores.Modificar(aModificar, clienteNuevo);

            CargarMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteBorrar = new Cliente("Juan Perez", 1234, "Larrea 492", 52);

            dgMayores.DataSource = null;

            mayores.Borrar(clienteBorrar);

            CargarMayores();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            mayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgMayores.DataSource = null;
            dgMayores.Refresh();

            mayores.LimpiarLista();
        }
    }
}