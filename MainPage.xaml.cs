
namespace ReveloJExamenP2
{
   public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private double ConvertVolume(double value, string fromUnit, string toUnit)
        {
            double valorEnLitros = fromUnit switch
            {
                "Litros" => value,
                "Galones" => value * 3.78541,
                "Metros Cúbicos" => value * 1000,
                _ => value
            };
            return toUnit switch
            {
                "Litros" => valorEnLitros,
                "Galones" => valorEnLitros / 3.78541,
                "Metros Cúbicos" => valorEnLitros / 1000,
                _ => valorEnLitros
            };
        }
    }
}
