using CAN.Task6SQLite.Core;
using CAN.Task6SQLite.View.Pages;
using System.Windows;
using System.Windows.Input;

namespace CAN.Task6SQLite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Util.UtilFrame = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
