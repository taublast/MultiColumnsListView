using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using AppoMobi.Xam;
using Xamarin.Forms;

using MultiColumnMonkeys.Models;
using MultiColumnMonkeys.Views;

namespace MultiColumnMonkeys.ViewModels
{


    public class ItemsViewModel : BaseViewModel
    {
        public XamObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        protected int IndexForAdd { get; set; } //not needed just a visual helper

        private int _Columns;
        public int Columns
        {
            get { return _Columns; }
            set
            {
                if (_Columns != value)
                {
                    _Columns = value;
                    OnPropertyChanged();
                }
            }
        }

        public async Task OpenPageNewItem(INavigation navigation)
        {
            IndexForAdd++;
            await navigation.PushModalAsync(new NavigationPage(new NewItemPage(IndexForAdd)));
        }


        public ItemsViewModel(int columns)
        {
            Columns = columns;

            Title = "Browse";

            Items = new XamObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;

                Items.AddItemLinkSetPosition(newItem); // link item, use this for simple list too
                Items.NotifyRowChanged(item, Columns); // <-- observable collection refresh for items inside one row

                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);

                // 2 ways of doing this:
                // link all then add 
                //faster for large chunks because of observable collections updates
                items.LinkItemsSetPositions(); // link all items, use this with simple lists too
                foreach (var item in items)
                {
                    Items.Add(item);
                }

                //or
                // link each during adding
                /*
                foreach (var item in items)
                {
                    Items.AddItemLinkSetPosition(item);
                    Items.NotifyRowChanged(item, Columns); // <-- observable collection refresh for items inside one row
                }
                */
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async void RedrawList()
        {
            Debug.WriteLine("[LIST] Redrawing..");
            foreach (var item in Items)
            {
                Items.ReportItemChange(item);
            }
            
        }
    }
}