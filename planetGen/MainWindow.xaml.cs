using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace planetGen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            genPlanetSize();
            genPlanetType();
            Output Output = new Output();
            Output.Show();
            this.Close();
        }

        // Generate the Size of Planet upon clicking button
        public static String genPlanetSize()
        {
            PlanetSize[] allPlanetSizes = (PlanetSize[])Enum.GetValues(typeof(PlanetSize));
            int randomIndex = new Random().Next(allPlanetSizes.Length);
            String planetSize = allPlanetSizes[randomIndex].ToString();
            //Trace.WriteLine(planetSize);
            return planetSize;
        }

        // Generate the Type of Planet upon clicking button
        public static String genPlanetType()
        {
            PlanetType[] allPlanetTypes = (PlanetType[])Enum.GetValues(typeof(PlanetType));
            int randomIndex = new Random().Next(allPlanetTypes.Length);
            String planetType = allPlanetTypes[randomIndex].ToString();
            Trace.WriteLine(planetType);
            return planetType;
        }
    }
}

