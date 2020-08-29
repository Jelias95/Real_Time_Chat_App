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

        // Var to track current chatting window
        public string currentChat;

        // TODO: Replace with actual call to get users
        public List<string> allUsers = new List<string> { "bob", "samantha" };

        // TODO: Replace with actual call to get users
        public List<string> allGroups = new List<string> { "general", "group 1", "group 2" };

        // TODO: Replace with real user permission list
        public bool group2Permission = false;

        // TODO: Replace with real list of access requests
        public int numOfRequests = 0;

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
            GetMessages();
            new Thread(new ThreadStart(this.CheckForMessages)).Start();
            new Thread(new ThreadStart(this.CheckForUsers)).Start();
            new Thread(new ThreadStart(this.CheckForGroups)).Start();
            new Thread(new ThreadStart(this.CheckForGroupRequests)).Start();
        }

        // Function called when a user is selected
        private void UserChanged(object sender, RoutedEventArgs e)
        {
            ListBoxItem listItem = (ListBoxItem)users.SelectedItem;
            if (users.SelectedItem != null)
            {
                currentChat = listItem.Content.ToString();
            }
        }

        // Function called when a group is selected
        private void GroupChanged(object sender, RoutedEventArgs e)
        {
            ListBoxItem listItem = (ListBoxItem)groups.SelectedItem;
            if (listItem != null)
            {
                if (group2Permission || listItem.Content.ToString() != "group 2")
                {
                    currentChat = listItem.Content.ToString();
                } else
                {
                    MessageBox.Show("You are not a member of this group");
                    groups.SelectedIndex = -1;
                }
            }
        }

        // Function to get all users
        private void GetUsers()
        {
            foreach(string usr in allUsers)
            {
                users.Items.Add(new ListBoxItem { Content = usr });
            }
        }

        // Function to get all groups
        private void GetGroups()
        {
            foreach(string group in allGroups)
            {
                groups.Items.Add(new ListBoxItem { Content = group, IsSelected = (group == "general") });
            }
        }

        // Function to get messages for a selected group
        private void GetMessages()
        {
            messages.Items.Clear();
            foreach (string msg in msgs[currentChat])
            {
                messages.Items.Add(new ListBoxItem { Content = msg });
            }
        }

        // Function to send a message
        private void SendMessage(object sender, RoutedEventArgs e)
        {
            string msg = messageBox.Text;
            msgs[currentChat].Add(msg);
        }

        // Callback for users
        private void CheckForUsers()
        {
            int numberUsers = allUsers.Count;
            while(true)
            {
                if (numberUsers != allUsers.Count)
                {
                    foreach (string user in allUsers.Skip(numberUsers))
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            users.Items.Add(new ListBoxItem { Content = user });
                        });
                    }
                    numberUsers = allUsers.Count;
                }
                Thread.Sleep(1000);
            }
        }

        // Callback for groups
        private void CheckForGroups()
        {
            int numberGroups = allGroups.Count;
            while (true)
            {
                if (numberGroups != allGroups.Count)
                {
                    foreach (string group in allGroups.Skip(numberGroups))
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            groups.Items.Add(new ListBoxItem { Content = group });
                        });
                    }
                    numberGroups = allGroups.Count;
                }
                Thread.Sleep(1000);
            }
        }

        // Callback for messages
        private void CheckForMessages()
        {
            int numberMessages = msgs[currentChat].Count;
            string curr = currentChat;
            while (true)
            {
                if (curr != currentChat)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        this.GetMessages();
                    });
                    curr = currentChat;
                } else if (numberMessages != msgs[currentChat].Count)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        foreach (string msg in msgs[currentChat].Skip(numberMessages))
                        {
                            messages.Items.Add(new ListBoxItem { Content = msg });
                        }
                    });
                    numberMessages = msgs[currentChat].Count;
                }
                Thread.Sleep(1000);
            }
        }

        // Callback for group requests
        private void CheckForGroupRequests()
        {
            while (true)
            {
                if (numOfRequests > 0)
                {
                    while (numOfRequests > 0)
                    {
                        MessageBox.Show("Temporary Message Assuming Group 2 Access Approval");
                        numOfRequests--;
                    }
                    group2Permission = true;
                }
                Thread.Sleep(15000);
            }
        }

        // TODO: Dummy request access request
        private void RequestAccess(object sender, RoutedEventArgs e)
        {
            RequestGroupAccess accessWindow = new RequestGroupAccess();
            accessWindow.Show();
            numOfRequests++;
        }
    }
}
