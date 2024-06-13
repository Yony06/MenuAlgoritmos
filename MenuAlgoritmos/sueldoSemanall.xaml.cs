namespace MenuAlgoritmos;

public partial class sueldoSemanall : ContentPage
{
	public sueldoSemanall()
	{
		InitializeComponent();
	}
    private void OnCounterClicked(object sender, EventArgs e)
    {
        //Colocamos un if donde validamos la entrada de texto segun lo requerido
        if (!string.IsNullOrEmpty(Horas.Text) && !string.IsNullOrEmpty(Pago.Text))
        {
            //Declaramos las variables a utilizar
            int ht;
            int ph;
            int Resultado;

            //Convertimos las variables que se ingresaran a los entry
            ht = Convert.ToInt32(Horas.Text);
            ph = Convert.ToInt32(Pago.Text);
            //La variable resultado se declara y se coloca la formula que se realizará que seria la de multiplicar los valores ingresados
            Resultado = (ph * ht);
            //Se muestra el resultado en el entry declarado
            Sueldo.Text = Resultado.ToString();

        }
        else
        {
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Digite los dos valores", "Listo");
        }

    }
}