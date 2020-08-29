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
using System.Windows.Shapes;

namespace RealTimeChatApp
{
    /// <summary>
    /// Interaction logic for RequestAccess.xaml
    /// </summary>
    public partial class RequestGroupAccess : Window
    {
        public RequestGroupAccess()
        {
            InitializeComponent();
        }

        // TODO: Replace with real logic to provide access
        private void SubmitRequest(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
