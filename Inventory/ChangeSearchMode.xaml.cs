using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inventory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeSearchMode : Popup
    {

        public static string currentSearchMode;

        public ChangeSearchMode()
        {
            InitializeComponent();

            searchModePicker.Items.Add("Item Name");
            searchModePicker.Items.Add("Floor");
            searchModePicker.Items.Add("Room");
            searchModePicker.Items.Add("Place");
            if (currentSearchMode != null)
                searchModePicker.SelectedItem = currentSearchMode;
            else
            {
                searchModePicker.SelectedIndex = 0;
                currentSearchMode = searchModePicker.SelectedItem.ToString();
            }                
        }

        private void searchModePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchPage.searchModeText.Text = searchModePicker.SelectedItem.ToString();
            currentSearchMode = searchModePicker.SelectedItem.ToString();
        }
    }
}