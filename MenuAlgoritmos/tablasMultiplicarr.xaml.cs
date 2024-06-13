namespace MenuAlgoritmos;

public partial class tablasMultiplicarr : ContentPage
{
	public tablasMultiplicarr()
	{
		InitializeComponent();
	}

    //En el evento OnCounterClicked usamos un if para mostrar las tablas de multiplicar segun el numero que a escrito el usuario 
    private void OnCounterClicked(object sender, EventArgs e)
    {
        ResultadoStackLayout.Children.Clear();

        if (int.TryParse(NumeroEntry.Text, out int numero))
        {
            for (int i = 1; i <= 10; i++)
            {
                var label = new Label
                {
                    Text = $"{numero} x {i} = {numero * i}",
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center
                };
                ResultadoStackLayout.Children.Add(label);
            }
        }

        //Y si el usuario ingresa un numero incorrecto mostrara un mensaje en letras rojas donde pide que ingrese el usuario numeros validos
        else
        {
            var errorLabel = new Label
            {
                Text = "Por favor, ingrese un número válido.",
                TextColor = Colors.Red,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            ResultadoStackLayout.Children.Add(errorLabel);
        }
    }
}