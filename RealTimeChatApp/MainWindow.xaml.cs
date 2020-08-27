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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RealTimeChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        // Dummy message holder
        public Dictionary<string, List<string>> msgs;

        // MainWindow constructor
        public MainWindow()
        {
            InitializeComponent();
        }

        // Function called when the window loads
        private void AppLoaded(object sender, RoutedEventArgs e)
        {
            msgs = new Dictionary<string, List<string>> {
                {"bob", new List<string> {"Hello User", "Hello Bob" }},
                {"samantha", new List<string> {"Hello Samantha", "Hello User!"}},
                {"general", new List<string> {"Hello everyone! This is Bob", "This is User!", "This is Samantha!"}},
                {"group 1", new List<string> {"Welcome to the group 1 chat!"}},
                {"group 2", new List<string> {"Welcome to group 2 chat"}}
            };
            GetUsers();
            GetGroups();
        }

        // Function called when a user is selected
        private void UserChanged(object sender, RoutedEventArgs e)
        {
            ListBoxItem listItem = (ListBoxItem)users.SelectedItem;
            if (users.SelectedItem != null)
            {
                GetMessages(listItem.Content.ToString());
            }
        }

        // Function called when a group is selected
        private void GroupChanged(object sender, RoutedEventArgs e)
        {
            ListBoxItem listItem = (ListBoxItem)groups.SelectedItem;
            if (listItem != null)
            {
                GetMessages(listItem.Content.ToString());
            }
        }

        // Function to get all users
        private void GetUsers()
        {
            // TODO: Replace with actual call to get users
            List<string> allUsers = new List<string> { "bob", "samantha" };
            foreach(string usr in allUsers)
            {
                this.Dispatcher.Invoke(() =>
                {
                    users.Items.Add(new ListBoxItem { Content = usr });
                });
            }
        }

        // Function to get all groups
        private void GetGroups()
        {
            // TODO: Replace with actual call to get users
            List<string> allGroups = new List<string> { "general", "group 1", "group 2" };
            foreach(string group in allGroups)
            {
                this.Dispatcher.Invoke(() =>
                {
                    groups.Items.Add(new ListBoxItem { Content = group, IsSelected = (group == "general") });
                });
            }
        }

        // Function to get messages for a selected group
        private void GetMessages(string messageGroup)
        {
            messages.Items.Clear();
            foreach (string msg in msgs[messageGroup])
            {
                messages.Items.Add(new ListBoxItem { Content = msg });
            }
        }
    }
}
