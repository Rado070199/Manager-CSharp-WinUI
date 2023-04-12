// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using ManagerAPI.Models;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ManagerUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7163/customers");
            var json = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<List<Customer>>(json);

            CustomersListView.ItemsSource = customers;
        }
    }
}
