namespace MenuAlgoritmos;

public partial class empresaImportadoraa : ContentPage
{
    int count = 0;
    // Constante que define la tasa de cambio de pesos a dólares
    private const decimal ExchangeRate = 18.0m;

    public empresaImportadoraa()
	{
		InitializeComponent();
	}
    // Método que se ejecuta cuando se hace clic en el botón
    private void Button_Clicked(object sender, EventArgs e)
    {
        // Convierte el texto ingresado en PesosEntry a un valor decimal
        if (decimal.TryParse(PesosEntry.Text, out decimal pesos))
        {
            // Calcula el valor en dólares dividiendo el valor en pesos por la tasa de cambio
            decimal dollars = pesos / ExchangeRate;
            // Actualiza el texto de ResultadoLabel con el resultado formateado a dos decimales
            ResultadoLabel.Text = $"Resultado: ${dollars:F2} USD";
        }
    }
}