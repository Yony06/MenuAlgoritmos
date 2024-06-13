namespace MenuAlgoritmos;

public partial class cuentaRegresivaa : ContentPage
{
    // Almacenar� el valor inicial del contador
    private int _count = 10;
    // Nos servir� el temporizador que manejar� el conteo regresivo
    private IDispatcherTimer _timer;

    public cuentaRegresivaa()
	{
		InitializeComponent();
        // Inicia el conteo cuando la p�gina se carga
        StartCountdown();
    }
    // M�todo para iniciar el temporizador del conteo regresivo
    private void StartCountdown()
    {
        // Crea una nueva instancia del temporizador
        _timer = Dispatcher.CreateTimer();
        // Establece el intervalo de tiempo del temporizador a 1 segundo
        _timer.Interval = TimeSpan.FromSeconds(1);
        // Inicia el temporizador
        _timer.Tick += _timer_Tick; ;
        _timer.Start();
    }

    private void _timer_Tick(object? sender, EventArgs e)
    {
        // Disminuye el contador en 1
        _count--;
        // Actualiza el texto con el valor actual del contador
        CountdownLabel.Text = _count.ToString();

        // Si el contador llega a 0, detiene el temporizador
        if (_count == 0)
        {

            _timer.Stop();
        }
    }
}