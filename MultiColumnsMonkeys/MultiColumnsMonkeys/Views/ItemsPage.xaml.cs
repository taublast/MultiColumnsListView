using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MultiColumnMonkeys.Models;
using MultiColumnMonkeys.Views;
using MultiColumnMonkeys.ViewModels;

namespace MultiColumnMonkeys.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();


            //without this on iOS ListView is UNDER Shell NavBar
            // https://github.com/xamarin/Xamarin.Forms/issues/4752
            Shell.SetSetPaddingInsets(this, true);


            BindingContext = viewModel = new ItemsViewModel(1);
           
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await viewModel.OpenPageNewItem(Navigation);
            //await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        async void Columns_Clicked(object sender, EventArgs e)
        {

            Device.BeginInvokeOnMainThread(() =>
            {
                // Update the UI
                var cols = ItemsListView.Columns;
                cols++;
                if (cols > 3) cols = 1;
                ItemsListView.Columns = cols;
                viewModel.Columns = cols;
                viewModel.RedrawList();
            });


        }





        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}