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

namespace RealTimeChatApp
{
    /// <summary>
    /// Interaction logic for ChatBox.xaml
    /// </summary>
    public partial class ChatBox : UserControl
    {
        public ChatBox()
        {
            InitializeComponent();
        }

        public Label MessageTitle
        {
            get { return Title; }
            set { Title = value; }
        }

        public Button SendMessageButton
        {
            get { return SendMessageButton; }
            set { SendButton = value; }
        }

        public ScrollViewer ContentScrollViewer
        {
            get { return ContentScroller; }
            set { ContentScroller = value; }
        }

        public TextBox MessageContainer
        {
            get { return MessageContent; }
            set { MessageContent = value; }
        }

        public ItemsControl MessageDisplay
        {
            get { return MessageTemplate; }
            set { MessageTemplate = value; }
        }
    }
}
