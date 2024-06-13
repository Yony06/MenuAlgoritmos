namespace MenuAlgoritmos;

public partial class langostaAhumadaa : ContentPage
{
	public langostaAhumadaa()
	{
		InitializeComponent();
	}
    //En el evento OnCounterClicked se coloca un if con el
    //procedimiento para obtener el precio de numero de platos
    //dependiendo la cantidad de el usuario
    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (int.TryParse(numeroPersonas.Text, out int np))
        {
            double cp = 95;

            if (np > 200 && np <= 300)
            {
                cp = 85;
            }
            else if (np > 300)
            {
                cp = 75;
            }
            double ct = np * cp;
            resultadoLabel.Text = $"El costo total es: ${ct:0.00}";
        }
        else
        {
            resultadoLabel.Text = "Por favor, ingrese un número válido de personas.";
        }
    }
}