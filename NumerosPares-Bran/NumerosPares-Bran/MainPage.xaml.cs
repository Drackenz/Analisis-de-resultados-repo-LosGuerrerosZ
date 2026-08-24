namespace NumerosPares_Bran;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void MostrarPares_Clicked(object sender, EventArgs e)
    {
        string numeros = "";

        for (int i = 0; i <= 100; i = i + 2)
        {
            numeros = numeros + i + "\n";
        }

        resultado.Text = numeros;
    }
}