using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Digital_Cloud_Technologies_Test_Task
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

        private async void MainButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient coingeckoClient = new HttpClient();
            string url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1";
            string key = "CG-Y6FynVZbsykxJXXv72BgLVik";
            
            try
            {
               
                coingeckoClient.DefaultRequestHeaders.Add("x-cg-demo-api-key", key);
                string jsonResult = await coingeckoClient.GetStringAsync(url);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Coin>? coins = JsonSerializer.Deserialize<List<Coin>>(jsonResult, options);

                if(coins != null)
                {
                    CoinsDataGrid.ItemsSource = coins;
                }

                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}