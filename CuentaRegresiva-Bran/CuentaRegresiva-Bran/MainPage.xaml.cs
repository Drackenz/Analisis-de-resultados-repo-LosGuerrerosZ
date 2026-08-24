namespace CuentaRegresiva_Bran;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void MostrarCuenta_Clicked(object sender, EventArgs e)
    {
        string cuenta = "";

        for (int i = 10; i >= 1; i--)
        {
            cuenta = cuenta + i + "\n";
        }

        resultado.Text = cuenta;
    }
}