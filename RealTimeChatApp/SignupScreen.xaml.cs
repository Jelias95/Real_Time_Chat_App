using System.Threading;
using System.Windows;

namespace RealTimeChatApp
{
    /// <summary>
    /// Interaction logic for SignupScreen.xaml
    /// </summary>
    public partial class SignupScreen : Window
    {
        // Boolean tracking if user is created
        public bool isUserCreated;

        // Constructor for signup screen
        public SignupScreen()
        {
            isUserCreated = false;
            InitializeComponent();
        }

        // Callback method that displays creation notice
        private void DisplayCreationMessage()
        {
            while(!isUserCreated)
            {
                Thread.Sleep(500);
            }

            this.Dispatcher.Invoke(() =>
            {
                MessageBox.Show("User is created!");
            });
        }

        // Method to create user (dummy method)
        private bool AttemptUserCreation(string fName, string lName, string username, string password)
        {
            return true;
        }

        // Method called by button click
        private void CreateUser(object sender, RoutedEventArgs e)
        {
            isUserCreated = AttemptUserCreation(inputFName.Text, inputLName.Text, inputUsername.Text, inputPassword.Password);
            if (isUserCreated)
            {
                MainWindow generalChat = new MainWindow();
                generalChat.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Unable to create user");
            }
        }

        // Background listener thread created on screen load
        private void SignupLoaded(object sender, RoutedEventArgs e)
        {
            new Thread(new ThreadStart(this.DisplayCreationMessage)).Start();
        }
    }
}
