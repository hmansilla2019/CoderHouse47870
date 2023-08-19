namespace AppDesktop
{
    public partial class Form1 : Form
    {
        const string Empresa = "CoderHouse";


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Empresa;

            lblBienvenida.Text += " A " + Empresa;
             
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string sNombre = string.Empty;

            sNombre = txtValorNombre.Text;

            lblResultado.Text = "Bievenido/a " + sNombre +
                                " a " + Empresa;

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            const double pi = 3.14159;
            double area_circulo;
            int radiocirculo = 1;
            string resultado = "El area del circulo es ";

            radiocirculo = Convert.ToInt32(numRadio.Value);

            area_circulo = pi * (radiocirculo * radiocirculo);

            lblResultadoArea.Text = resultado + area_circulo;

        }
    }
}