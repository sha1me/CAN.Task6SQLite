using CAN.Task6SQLite.Core;
using CAN.Task6SQLite.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task6SQLite.View.Pages
{
    public partial class RegistrationPage : Page
    {
        private ModelContext? db = null;
        private User _user = new User();
        public RegistrationPage()
        {
            InitializeComponent();

            db = new ModelContext();
        }

        private void BtnCreat_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) ||
                string.IsNullOrEmpty(PbPassword.Password))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                try
                {

                    _user.Login = TbLogin.Text;
                    _user.Password = PbPassword.Password;
                    _user.RoleID = 2;

                    MessageBox.Show("Аккаунт пользователя успешно создан",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);

                    db?.Users.Add(_user);
                    db?.SaveChanges();

                    Util.UtilFrame?.Navigate(new LoginPage());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(),
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new LoginPage());
        }
    }
}
