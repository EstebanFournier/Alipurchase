using AliPurchase.Views;
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

namespace AliPurchase
{
    /// <summary>
    /// Logique d'interaction pour AuthenticateWindow.xaml
    /// </summary>
    public partial class AuthenticateWindow : Window
    {
        public AuthenticateWindow()
        {
            InitializeComponent();
        }

        private void Btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            // Call the shellWindow view and close without verifying the credentials : todo
            ShellWindow mainWindow = new ShellWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
