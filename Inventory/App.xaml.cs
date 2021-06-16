using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inventory
{
    public partial class App : Application
    {

        public static string FilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ItemsPage());
        }

        public App(string filepath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ItemsPage());

            FilePath = filepath;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
