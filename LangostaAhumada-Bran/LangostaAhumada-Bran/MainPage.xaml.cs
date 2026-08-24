namespace LangostaAhumada_Bran;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void CalcularPresupuesto_Cliked(object sender, EventArgs e)
    {
        int cantidadPersonas;

        bool cantidadCorrecta = int.TryParse(personas.Text, out cantidadPersonas);

        if (cantidadCorrecta && cantidadPersonas > 0)
        {
            double costoPlatillo;

            if (cantidadPersonas <= 200)
            {
                costoPlatillo = 95;
            }
            else if (cantidadPersonas <= 300)
            {
                costoPlatillo = 85;
            }
            else
            {
                costoPlatillo = 75;
            }

            double presupuesto = cantidadPersonas * costoPlatillo;

            resultado.Text = "Personas: " + cantidadPersonas +
                             "\nCosto por platillo: $" + costoPlatillo.ToString("0.00") +
                             "\nPresupuesto total: $" + presupuesto.ToString("0.00");
        }
        else
        {
            resultado.Text = "Ingrese una cantidad válida de personas.";
        }
    }
}