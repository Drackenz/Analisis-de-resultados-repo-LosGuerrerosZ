namespace SueldoSemanal_Bran;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void CalcularSueldo_Clicked(object sender, EventArgs e)
    {
        double horasTrabajadas;
        double pagoPorHora;

        bool horasCorrectas = double.TryParse(horas.Text, out horasTrabajadas);
        bool pagoCorrecto = double.TryParse(pagoHora.Text, out pagoPorHora);

        if (horasCorrectas && pagoCorrecto && horasTrabajadas >= 0 && pagoPorHora >= 0)
        {
            double sueldo = horasTrabajadas * pagoPorHora;

            resultado.Text = "El sueldo semanal es: $" + sueldo.ToString("0.00");
        }
        else
        {
            resultado.Text = "Ingrese valores válidos.";
        }
    }
}