using System;
using AppoMobi.Xam;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiColumnsMonkeys.Views
{ 
    // was subclasssed just for demo, not really used in this example

    public partial class MonkeysRow : MultiColumnsCell
    {
        
        public MonkeysRow(Type childCell, XamListView list) : base(childCell, list)
        {
            MainGrid.BackgroundColor = Color.WhiteSmoke;
        }

        public override void SetupCell()
        {



            base.SetupCell();
        }

        
    }

}