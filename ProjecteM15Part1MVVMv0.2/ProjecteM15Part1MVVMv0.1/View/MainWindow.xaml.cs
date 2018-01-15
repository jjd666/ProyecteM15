using ProjecteM15Part1MVVMv0._1.View;
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

namespace ProjecteM15Part1MVVMv0._1
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

        private void buttonCliente_Click(object sender, RoutedEventArgs e)
        {
            VistaAdmin view = new VistaAdmin(); //VISTA DE CLIENTE
            view.Show();
        }

        private void buttonAdmin_Click(object sender, RoutedEventArgs e)
        {
            VistaClient view = new VistaClient(); //VISTA DE ADMIN
            view.Show();
        }
    }
}
