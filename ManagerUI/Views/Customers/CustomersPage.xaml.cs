using ManagerAPI.Models;
using ManagerUI.Views.Customers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace ManagerUI.Views
{
    public sealed partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            this.InitializeComponent();
            LoadCustomers();
        }

        private async void LoadCustomers()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7059/Customers");
            var json = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<List<Customer>>(json);

            CustomersListView.ItemsSource = customers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // utwórz nowe okno
            var newWindow = new Window();

            // utwórz nowy Frame, który bêdzie wyœwietla³ stronê CustomersPage
            var newFrame = new Frame();
            newFrame.Navigate(typeof(CustomerCreatePage));

            // ustaw zawartoœæ okna na nowy Frame
            newWindow.Content = newFrame;

            // otwórz nowe okno
            newWindow.Activate();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for editing an existing customer here.
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for deleting an existing customer here.
        }
        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for deleting an existing customer here.
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Implement logic for filtering the customer list here.
        }
    }
}
