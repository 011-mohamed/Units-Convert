using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnitsConvertor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // logic pour afficher le grid de Volume
        private void ShowVolumeGrid(object sender, RoutedEventArgs e)
        {
            VolumeGrid.Visibility = Visibility.Visible;
            volumesbtn.Visibility = Visibility.Collapsed;
            tempbtn.Visibility = Visibility.Collapsed;
            poidsbtn.Visibility = Visibility.Collapsed;
            longbtn.Visibility = Visibility.Collapsed;
            
        }

        // logic pour afficher le grid de longueur
        private void ShowLongGrid(object sender, RoutedEventArgs e)
        {
            LongueurGrid.Visibility = Visibility.Visible;
            VolumeGrid.Visibility = Visibility.Collapsed;
            volumesbtn.Visibility = Visibility.Collapsed;
            tempbtn.Visibility = Visibility.Collapsed;
            poidsbtn.Visibility = Visibility.Collapsed;
            longbtn.Visibility = Visibility.Collapsed;

        }

        // logic pour afficher le grid de Temp
        private void ShowTempGrid(object sender, RoutedEventArgs e)
        {
            TempGrid.Visibility = Visibility.Visible;
            LongueurGrid.Visibility = Visibility.Collapsed;
            VolumeGrid.Visibility = Visibility.Collapsed;
            volumesbtn.Visibility = Visibility.Collapsed;
            tempbtn.Visibility = Visibility.Collapsed;
            poidsbtn.Visibility = Visibility.Collapsed;
            longbtn.Visibility = Visibility.Collapsed;

        }

        // logic pour afficher le grid de Poids
        private void ShowPoidsGrid(object sender, RoutedEventArgs e)
        {
            PoidGrid.Visibility = Visibility.Visible;
            TempGrid.Visibility = Visibility.Collapsed;
            LongueurGrid.Visibility = Visibility.Collapsed;
            VolumeGrid.Visibility = Visibility.Collapsed;
            volumesbtn.Visibility = Visibility.Collapsed;
            tempbtn.Visibility = Visibility.Collapsed;
            poidsbtn.Visibility = Visibility.Collapsed;
            longbtn.Visibility = Visibility.Collapsed;

        }

        // logic pour afficher le grid de menu principal 
        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            // Logic for returning to the main menu, or simply hiding all grids
            VolumeGrid.Visibility = Visibility.Collapsed;
            LongueurGrid.Visibility = Visibility.Collapsed;
            TempGrid.Visibility = Visibility.Collapsed;
            PoidGrid.Visibility = Visibility.Collapsed;
            volumesbtn.Visibility = Visibility.Visible;
            tempbtn.Visibility = Visibility.Visible;
            poidsbtn.Visibility = Visibility.Visible;
            longbtn.Visibility = Visibility.Visible;
            


        }

        // Logic pour convertir Volume 
        private void ConvertButtonVolume_Click(object sender, RoutedEventArgs e)
        {
            // recuperer mes units
            string selectedUnitFrom = ((ComboBoxItem)VolumeCombobox.SelectedItem)?.Content.ToString();
            string selectedUnitTo = ((ComboBoxItem)VolumeCombobox_Copy.SelectedItem)?.Content.ToString();
            string inputValue = InputTextBox.Text;

            // validee mes input
            if (double.TryParse(inputValue, out double volume))
            {
                double convertedVolume;

               
                if (selectedUnitFrom == "Liters" && selectedUnitTo == "Gallons")
                {
                    // Convert liters to gallons
                    convertedVolume = volume * 0.264172; // Formula: Gallons = Liters * 0.264172
                    OutputTextBox.Text = $"{convertedVolume:F2} Gallons"; // Display result
                }
                else if (selectedUnitFrom == "Gallons" && selectedUnitTo == "Liters")
                {
                    // Convert gallons to liters
                    convertedVolume = volume * 3.78541; // Formula: Liters = Gallons * 3.78541
                    OutputTextBox.Text = $"{convertedVolume:F2} Liters"; // Display result
                }
                else
                {
                    // If no conversion needed, just display the original input
                    OutputTextBox.Text = $"{volume:F2}";
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Entrée Invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }




        private void ConvertButtonLong_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected units and input value
            string selectedUnitFrom = ((ComboBoxItem)LongueurBox.SelectedItem)?.Content.ToString();
            string selectedUnitTo = ((ComboBoxItem)LongueurBox_copy.SelectedItem)?.Content.ToString();
            string inputValue = InputTextBoxLongueur.Text;

            // Validate input
            if (double.TryParse(inputValue, out double length))
            {
                double convertedLength;

                // Perform conversion based on selected units
                if (selectedUnitFrom == "Metres" && selectedUnitTo == "Pieds")
                {
                    // Convert meters to feet
                    convertedLength = length * 3.28084; // Formula: Feet = Meters * 3.28084
                    OutputTextBoxLongueur.Text = $"{convertedLength:F2} Pieds"; // Display result
                }
                else if (selectedUnitFrom == "Pieds" && selectedUnitTo == "Metres")
                {
                    // Convert feet to meters
                    convertedLength = length / 3.28084; // Formula: Meters = Feet / 3.28084
                    OutputTextBoxLongueur.Text = $"{convertedLength:F2} Metres"; // Display result
                }
                else
                {
                    // If no conversion is needed, display the original value
                    OutputTextBoxLongueur.Text = $"{length:F2}";
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Entrée Invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void ConvertTemp(object sender, RoutedEventArgs e)
        {
            // Get the selected units and input value
            string selectedUnitFrom = ((ComboBoxItem)tempBox.SelectedItem)?.Content.ToString();
            string selectedUnitTo = ((ComboBoxItem)tempBox_copy.SelectedItem)?.Content.ToString();
            string inputValue = InputTextBoxTemp.Text;

            // Validate input
            if (double.TryParse(inputValue, out double temperature))
            {
                double convertedTemperature;

                // Perform conversion based on selected units
                if (selectedUnitFrom == "Celsius" && selectedUnitTo == "Fahrenheit")
                {
                    // Convert Celsius to Fahrenheit
                    convertedTemperature = (temperature * 9 / 5) + 32; // Formula: F = C * 9/5 + 32
                    OutputTextBoxTemp.Text = $"{convertedTemperature:F2} °F"; // Display result
                }
                else if (selectedUnitFrom == "Fahrenheit" && selectedUnitTo == "Celsius")
                {
                    // Convert Fahrenheit to Celsius
                    double aux = temperature - 32;
                    double mul = 5 / 9;
                    convertedTemperature = aux * mul ; // Formula: C = (F - 32) * 5/9
                    OutputTextBoxTemp.Text = $"{convertedTemperature:F2} °C"; // Display result
                }
                else
                {
                    // If no conversion needed, just show the original input
                    OutputTextBoxTemp.Text = $"{temperature:F2}"; // Display original input
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Entrée Invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void ConvertPoids(object sender, RoutedEventArgs e)
        {
            // Get the selected unit and input value
            string selectedUnitFrom = ((ComboBoxItem)PoidBox.SelectedItem)?.Content.ToString();
            string selectedUnitTo = ((ComboBoxItem)PoidBox_copy.SelectedItem)?.Content.ToString();
            string inputValue = InputTextBoxPoids.Text;

            // Validate input
            if (double.TryParse(inputValue, out double weight))
            {
                double convertedValue;

                // Perform conversion based on the selected units
                if (selectedUnitFrom == "Kilogramme" && selectedUnitTo == "Livre")
                {
                    convertedValue = weight * 2.20462; // Convert kg to lbs
                    OutputTextBoxPoids.Text = $"{convertedValue:F2} Livres"; // Show result
                }
                else if (selectedUnitFrom == "Livre" && selectedUnitTo == "Kilogramme")
                {
                    convertedValue = weight / 2.20462; // Convert lbs to kg
                    OutputTextBoxPoids.Text = $"{convertedValue:F2} Kilogrammes"; // Show result
                }
                else
                {
                    // If no conversion needed, just show the original input
                    OutputTextBoxPoids.Text = inputValue;
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Entrée Invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

    }
}