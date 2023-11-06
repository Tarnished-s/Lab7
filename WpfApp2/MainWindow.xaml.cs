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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbox1.Text) || string.IsNullOrEmpty(txbox2.Text))
            { txbox3.Text = "Empty"; return; }
            var x1 = double.Parse(txbox1.Text); var x2 = double.Parse(txbox2.Text);
            var y = Math.Sqrt((Math.Pow(x2, 2) + x1 / x2) / 16 * x2 * x1);
            txbox3.Text = y.ToString();

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            txbox1.Text = string.Empty;
            txbox2.Text = string.Empty;
            txbox3.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();  
        }
    }
}
