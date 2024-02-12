using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Tmds.DBus.Protocol;

namespace lab2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "buttonKhaki":
                        colorRectangle.Fill = new SolidColorBrush(Colors.Khaki);
                        break;
                    case "buttonRed":
                        colorRectangle.Fill = new SolidColorBrush(Colors.Red);
                        break;
                    case "buttonMediumVioletRed":
                        colorRectangle.Fill = new SolidColorBrush(Colors.MediumVioletRed);
                        break;
                    case "buttonBisque":
                        colorRectangle.Fill = new SolidColorBrush(Colors.Bisque);
                        break;
                    case "buttonLemonChiffon":
                        colorRectangle.Fill = new SolidColorBrush(Colors.LemonChiffon);
                        break;
                    case "buttonPowderBlue":
                        colorRectangle.Fill = new SolidColorBrush(Colors.PowderBlue);
                        break;
                    case "buttonMintCream":
                        colorRectangle.Fill = new SolidColorBrush(Colors.MintCream);
                        break;
                    case "buttonMaroon":
                        colorRectangle.Fill = new SolidColorBrush(Colors.Maroon);
                        break;
                    case "buttonRosyBrown":
                        colorRectangle.Fill = new SolidColorBrush(Colors.RosyBrown);
                        break;
                    case "buttonLightPink":
                        colorRectangle.Fill = new SolidColorBrush(Colors.LightPink);
                        break;
                    default:
                        colorRectangle.Fill = new SolidColorBrush(Colors.Khaki);
                        break;
                }
            }
        }
    }
}