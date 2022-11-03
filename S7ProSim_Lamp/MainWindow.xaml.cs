using System;
using System.Collections.Generic;
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
using myS7ProSimLib;

namespace S7ProSim_Lamp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        myS7ProSimLib.S7ProSim sim = new myS7ProSimLib.S7ProSim();

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void connect_to_s7(object sender, RoutedEventArgs e)
        {
            sim.Connect();
            cpu_state.Content = sim.GetState();
            scan_mode.Content = sim.GetScanMode().ToString();

                
        }
    }
}
