using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RealTimeChatApp
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        // Boolean tracking if a user is authorized
        public bool isAuthorized;

        // Constructor for login screen
        public LoginScreen()
        {
            isAuthorized = false;
            InitializeComponent();
        }

        // Callback method that displays authorization notice
        private void DisplayAuthorizationMessage()
        {
            while (!isAuthorized)
            {
                Thread.Sleep(500);
            }

            this.Dispatcher.Invoke(() =>
            {
                    MessageBox.Show("User is authorized!");
            });
        }

        // Method to validate usernamen and password
        private bool IsAuthorizedUser(string username, string password)
        {
            return username == "User" && password == "Password";
        }

        // Method called by button click that lets authorized users into the app
        private void AttemptUserAuthentication(object sender, RoutedEventArgs e)
        {
            isAuthorized = IsAuthorizedUser(inputUsername.Text, inputPassword.Password);
            if (isAuthorized)
            {
                MainWindow generalChat = new MainWindow();
                generalChat.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Username/password combination not found");
            }
        }

        // Background listener thread created on screen load
        private void LoginLoaded(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.DisplayAuthorizationMessage));
            thread.Start();
        }
    }
}
