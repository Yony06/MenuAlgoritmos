namespace MenuAlgoritmos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void tablasMultiplicar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new tablasMultiplicarr());
        }

        private void cuentaRegresiva_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cuentaRegresivaa());
        }

        private void numerosPares_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new numerosParess());
        }

        private void sueldoSemanal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new sueldoSemanall());
        }

        private void langostaAhumada_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new langostaAhumadaa());
        }

        private void empresaImportadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new empresaImportadoraa());
        }
    }

}
