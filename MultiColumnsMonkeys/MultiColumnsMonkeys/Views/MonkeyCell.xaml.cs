using System.Runtime.CompilerServices;
using MultiColumnsMonkeys.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiColumnsMonkeys.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellMonkey  
    {
        public CellMonkey()
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