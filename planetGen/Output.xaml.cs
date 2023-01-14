using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace planetGen
{
    /// <summary>
    /// Interaction logic for Output.xaml
    /// </summary>
    public partial class Output : Window
    {
        public Output()
        {
            InitializeComponent();
            textDisplay();
        }

        private void goBackFromOutput_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void textDisplay()
        {
            String pSize = MainWindow.genPlanetSize();
            String pType = MainWindow.genPlanetType();
            Size.Text = pSize;
            Type.Text = pType;
        }
    }

}
