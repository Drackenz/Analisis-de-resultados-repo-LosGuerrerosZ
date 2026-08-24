namespace TablasMultiplicar_Bran;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void MostrarTablas_Clicked(object sender, EventArgs e)
    {
        string tablas = "";

        for (int i = 1; i <= 10; i++)
        {
            tablas = tablas + "Tabla del " + i + "\n";

            for (int j = 1; j <= 10; j++)
            {
                int respuesta = i * j;

                tablas = tablas + i + " x " + j + " = " + respuesta + "\n";
            }

            tablas = tablas + "\n";
        }

        resultado.Text = tablas;
    }
}