using System.Runtime.CompilerServices;
using MultiColumnMonkeys.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiColumnMonkeys.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyCellCentered
    {
        public MonkeyCellCentered()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as Item;
            if (item == null) return;


            // todo can setup your sell at will
        }
    }
}