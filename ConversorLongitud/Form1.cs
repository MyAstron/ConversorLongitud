namespace ConversorLongitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ValorKilometros;
            ValorKilometros = Double.Parse(udKilometros.Text);
            txtPulgada.Text = (ValorKilometros * 39370.1).ToString();
            txtMetro.Text = (ValorKilometros * 1000).ToString();
            txtPie.Text = (ValorKilometros * 3280.84).ToString();
            txtYarda.Text = (ValorKilometros * 1093.61).ToString();
            txtCentimetro.Text = (ValorKilometros * 100000).ToString();
            txtMillaMaritima.Text = (ValorKilometros * 0.54).ToString();
            txtMilimetro.Text = (ValorKilometros * 1000000).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPulgada.Text = "Pulgada";
            txtMetro.Text = "Metros";
            txtPie.Text = "Pies";
            txtYarda.Text = "Yardas";
            txtCentimetro.Text = "Centimetros";
            txtMillaMaritima.Text = "Milla Maritima";
            txtMilimetro.Text = "Milimetro";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}