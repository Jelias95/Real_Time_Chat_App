using System.Threading;
using System.Windows;

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

        // Method to validate username and password
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
            new Thread(new ThreadStart(this.DisplayAuthorizationMessage)).Start();
        }

        // Method to open signup form
        private void OpenSignupForm(object sender, RoutedEventArgs e)
        {
            SignupScreen signupScreen = new SignupScreen();
            signupScreen.Show();
            this.Close();
        }
    }
}
