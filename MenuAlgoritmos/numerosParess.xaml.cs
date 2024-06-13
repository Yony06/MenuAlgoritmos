namespace MenuAlgoritmos;

public partial class numerosParess : ContentPage
{
	public numerosParess()
	{
		InitializeComponent();
	}
    private void OnCounterClicked(object sender, EventArgs e)
    {
        //Declaramos la variable que guarda el metodo de elo que se mostrara en el label
        string numerosPares = ObtenerNumerosPares();
        Mostrar.Text = numerosPares;
    }

    //Metodo a mostrar
    private string ObtenerNumerosPares()
    {
        //Declaramos una variable que se poddra modificar
        //Luego declaramos un for que lleva el procedimiento para mostrar los numeros pares
        //Reetornamos la variable pero de manera de cadena de texto

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int i = 0; i <= 100; i += 2)
        {
            sb.Append(i);
            sb.Append(", ");
        }
        sb.Length -= 2;
        return sb.ToString();
    }
}