﻿using AWP_Foreign_Languages_WPF.Models;
using AWP_Foreign_Languages_WPF.View.MainFrame.Students;
using AWP_Foreign_Languages_WPF.View.MainFrame.Teacher;
using AWP_Foreign_Languages_WPF.View.MainFrame.Administrator;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using AWP_Foreign_Languages_WPF.Assets.Enums;

namespace AWP_Foreign_Languages_WPF.View.MainFrame
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Core db = new Core();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string phone = TextBoxPhone.Text.Trim();
            string password = TextBoxPassword.Text;


            if (phone.Length != 11)
            {
                MessageBox.Show(ExceptionsEnum.PhoneException);
                return;
            }

            List<User> users = db.context.User.Where(x => x.PhoneUser == phone && x.PasswordUser == password).ToList();
            int count = users.Count;
            if (count > 0)
            {
                User user = users.FirstOrDefault();
                App.ActiveUser = user;

                if (user.Role.NameRole == RolesEnum.Client)
                {
                    NavigationService.Navigate(new StudentPage());
                    ShowPersonalPageButton();
                }
                else if (user.Role.NameRole == RolesEnum.Teacher)
                {
                    NavigationService.Navigate(new TeacherPage());
                    ShowPersonalPageButton();
                }
                else if (user.Role.NameRole == RolesEnum.Administrator)
                {
                    NavigationService.Navigate(new AdministratorPage());
                    ShowPersonalPageButton();
                }
                else if (user.Role.NameRole == RolesEnum.TestMode)
                {
                    // NavigationService.Navigate(new StudentPage());
                }
                else
                {
                    MessageBox.Show(ExceptionsEnum.RoleException);
                }
            }
            else
            {
                MessageBox.Show(ExceptionsEnum.AuthException);
            }
        }
        private void ShowPersonalPageButton()
        {
            App.PersonalPageButton.Visibility = Visibility.Visible;

            App.LogoutBorder.Visibility = Visibility.Visible;
            App.LoginBorder.Visibility = Visibility.Collapsed;
        }
    }
}