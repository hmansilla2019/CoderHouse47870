namespace ListasBasicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] razasDePerrosArray = new string[5];
            string[] razasDePerrosArray2 = { "Bulldock", "Pastor alemnan",
                                            "Pequines", "Dogo argentino" };
            
           this.lblSaludo.Text += " Hugo";

            razasDePerrosArray[0] = "Dalmata";
            razasDePerrosArray[1] = "Ovejero Aleman";
            razasDePerrosArray[2] = "Salchichas";
            razasDePerrosArray[3] = "Caniche";
            razasDePerrosArray[4] = "Pequines";

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                this.lstRazas.Items.Add(razasDePerrosArray[i]);
            }

            for (int i = 0; i < razasDePerrosArray2.Length; i++)
            {
                this.lstRazas.Items.Add(razasDePerrosArray2[i]);
            }

            float mayor = 0;
            Producto[] BebidasGaseosas =
            {
                new Producto() { Id=1, Nombre="Coca Cola", PrecioCompra=1700.0f, Categoria="Gaseosa"},
                new Producto() { Id=2, Nombre="Pepsi", PrecioCompra=1800.0f, Categoria="Gaseosa"},
                new Producto() { Id=3, Nombre="SevenUp", PrecioCompra=1500.0f, Categoria="Gaseosa"},
                new Producto() { Id=4, Nombre="Manaos", PrecioCompra=150.0f, Categoria="Gaseosa"}
            };

            foreach (var item in BebidasGaseosas)
            {
                if (item.PrecioCompra>mayor)
                {
                    mayor = item.PrecioCompra;
                }
            }

            this.lblPrecioMayor.Text += mayor;

          
            ciudadesxPaises.Add("Bucaramnga", "Chile");
            ciudadesxPaises.Add("Bogota", "Colombia");
            ciudadesxPaises.Add("Sucre", "Bolivia");
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Rio de Janeiro", "Brasil");

            foreach (KeyValuePair<string,string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pais;
            int numero=4;
            int numero2=0;
            int division;
            try
            {
                division = numero / numero2;
                if (ciudadesxPaises.ContainsKey("Sucre"))
                {
                    ciudadesxPaises.TryGetValue("Sucre", out pais);
                    MessageBox.Show("El pais donde pertenece la ciudad Sucre es : " + pais);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se puede dividir por cero");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Remove("Bucaramnga");
            lstCiudadesxPaises.Items.Clear();
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }

        }

        private void btnMadificar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises["Buenos Aires"] = "Chile";
           
            lstCiudadesxPaises.Items.Clear();
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Clear();

            lstCiudadesxPaises.Items.Clear();

            MessageBox.Show("Se limpio el contenido del diccionario");
        }
    }
}