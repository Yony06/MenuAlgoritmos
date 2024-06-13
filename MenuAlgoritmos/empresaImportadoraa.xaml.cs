namespace MenuAlgoritmos;

public partial class empresaImportadoraa : ContentPage
{
    int count = 0;
    // Constante que define la tasa de cambio de pesos a d�lares
    private const decimal ExchangeRate = 18.0m;

    public empresaImportadoraa()
	{
		InitializeComponent();
	}
    // M�todo que se ejecuta cuando se hace clic en el bot�n
    private void Button_Clicked(object sender, EventArgs e)
    {
        // Convierte el texto ingresado en PesosEntry a un valor decimal
        if (decimal.TryParse(PesosEntry.Text, out decimal pesos))
        {
            // Calcula el valor en d�lares dividiendo el valor en pesos por la tasa de cambio
            decimal dollars = pesos / ExchangeRate;
            // Actualiza el texto de ResultadoLabel con el resultado formateado a dos decimales
            ResultadoLabel.Text = $"Resultado: ${dollars:F2} USD";
        }
    }
}