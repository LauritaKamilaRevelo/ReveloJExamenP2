
namespace ReveloJExamenP2
{
   public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private double ConvertVolume(double valor, string fromUnit, string toUnit)
        {
            double valorEnLitros = fromUnit switch
            {
                "Litros" => valor,
                "Galones" => valor * 3.785,
                "Metros Cubicos" => valor * 1000,
                _ => valor
            };
            return toUnit switch
            {
                "Litros" => valorEnLitros,
                "Galones" => valorEnLitros / 3.785,
                "Metros CUbicos" => valorEnLitros / 1000,
                _ => valorEnLitros
            };
        }
        private void KROnConvertButtonClicked(object sender, EventArgs e)
        {
            if (double.TryParse(KRValueEntry.Text, out double valor))
            {
                string fromUnit = KRFromUnitPicker.SelectedItem?.ToString();
                string toUnit = KRToUnitPicker.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(fromUnit) && !string.IsNullOrEmpty(toUnit))
                {
                    double result = ConvertVolume(valor, fromUnit, toUnit);
                    KRResultLabel.Text = $"{valor} {fromUnit} = {result:F5} {toUnit}";
                }
                else
                {
                    KRResultLabel.Text = "Selecciona unidades validas";
                }
            }
            else
            {
                KRResultLabel.Text = "Por favor, introduce un valor valido";
            }
        }
        private void KROnClearButtonClicked(object sender, EventArgs e)
        {
            KRValueEntry.Text = string.Empty;
            KRFromUnitPicker.SelectedItem = null;
            KRToUnitPicker.SelectedItem = null;
            KRResultLabel.Text = "Resultado";
        }
    }
}
