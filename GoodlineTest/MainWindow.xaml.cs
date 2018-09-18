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

using System.Net.Http;
using System.IO;
using System.Web.Script.Serialization;

namespace GoodlineTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id_page = 1;
        public MainWindow()
        {
            InitializeComponent();
            b_next.IsEnabled = false;
            b_prev.IsEnabled = false;

            string url = "https://reqres.in/api/users?page=" + id_page.ToString(); 
            var WebRequest = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = WebRequest.GetResponse();

            System.Net.WebClient cli = new System.Net.WebClient();

            cli.DownloadStringCompleted += Cli_DownloadStringCompleted;
            cli.DownloadStringAsync(new Uri(url));
        }

        private void Cli_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null && e.Result != "")
            {
                JavaScriptSerializer s = new JavaScriptSerializer();
                RootObject r = s.Deserialize<RootObject>(e.Result);
                
                if (r.total_pages > 1 )
                {
                    b_next.IsEnabled = true;
                    if (id_page == r.total_pages)
                        b_next.IsEnabled = false;
                    if (id_page > 1)
                        b_prev.IsEnabled = true;
                    else
                        b_prev.IsEnabled = false;
                }
                dgMain.ItemsSource = r.data;
                t_status.Content = "Success. Page " + id_page.ToString();
            }
            else
                t_status.Content = "Error. Unable to download page " + id_page.ToString();
        }

        private void b_next_Click(object sender, RoutedEventArgs e)
        {
            id_page++;
            t_status.Content = "Downloading page " + id_page.ToString() + "... ";
            string url2 = "https://reqres.in/api/users?page=" + id_page.ToString();
            System.Net.WebClient cli2 = new System.Net.WebClient();

            cli2.DownloadStringCompleted += Cli_DownloadStringCompleted;
            cli2.DownloadStringAsync(new Uri(url2));
        }

        private void b_prev_Click(object sender, RoutedEventArgs e)
        {
            id_page--;
            t_status.Content = "Downloading page " + id_page.ToString() + "... ";
            string url2 = "https://reqres.in/api/users?page=" + id_page.ToString();
            System.Net.WebClient cli2 = new System.Net.WebClient();

            cli2.DownloadStringCompleted += Cli_DownloadStringCompleted;
            cli2.DownloadStringAsync(new Uri(url2));
        }
    }
}
