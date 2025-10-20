namespace Potenciacao_base_expoente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores dos campos de texto
                double baseNumero = Convert.ToDouble(txtBase.Text);
                double expoente = Convert.ToDouble(txtExpoente.Text);

                // Calcula a potenciação
                double resultado = Math.Pow(baseNumero, expoente);

                // Exibe o resultado no label
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                lblResultado.Text = "Digite valores numéricos válidos.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Erro: {ex.Message}";
            }

        }
    }
}
