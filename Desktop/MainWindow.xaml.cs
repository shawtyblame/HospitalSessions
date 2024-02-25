using Desktop.ViewModels;
using System.Text.Json.Serialization;
using System.Windows;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel logModel = new LoginViewModel
            {
                Login = loginBox.Text,
                Password = passBox.Text,
            };
            var json = JsonConvert.SerializeObject(logModel);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://localhost:7279/Validate";
            var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("problem");
            }
        }
    }
}