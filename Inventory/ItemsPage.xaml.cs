using Inventory.Classes;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inventory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();            
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SeachEditPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Item>();
                var items = conn.Table<Item>().ToList();

                itemListView.ItemsSource = items;
            }
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }

        private async void itemListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Item;

            await Navigation.PushAsync(new SeachEditPage(details.ItemName, details.Floor, details.Room, details.Place));
        }
    }
}