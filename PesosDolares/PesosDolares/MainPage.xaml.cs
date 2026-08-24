using System.Globalization;

namespace PesosDolares;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnConvertirClicked(object sender, EventArgs e)
    {
        // Ocultar mensajes previos
        LabelError.IsVisible = false;
        FrameResultado.IsVisible = false;

        string textoPesos = EntryPesos.Text?.Trim() ?? string.Empty;
        string textoTipoCambio = EntryTipoCambio.Text?.Trim() ?? string.Empty;

        // Validar cantidad en pesos
        if (!decimal.TryParse(textoPesos, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal pesos) || pesos < 0)
        {
            MostrarError("Ingresa una cantidad válida de pesos mexicanos.");
            return;
        }

        // Validar tipo de cambio
        if (!decimal.TryParse(textoTipoCambio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal tipoCambio) || tipoCambio <= 0)
        {
            MostrarError("Ingresa un tipo de cambio válido (mayor que cero).");
            return;
        }

        // Cálculo: dólares = pesos / tipo de cambio (MXN por USD)
        decimal dolares = pesos / tipoCambio;

        LabelResultado.Text =
            $"{pesos:N2} MXN = {dolares:N2} USD" + Environment.NewLine +
            $"(Tipo de cambio usado: {tipoCambio:N4} MXN/USD)";

        FrameResultado.IsVisible = true;
    }

    private void MostrarError(string mensaje)
    {
        LabelError.Text = mensaje;
        LabelError.IsVisible = true;
    }
}