using System;
using System.ComponentModel.Design;
using AppoMobi.Xam;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiColumnMonkeys.Views
{ 
    // was subclasssed just for demo, not really used in this example

    public partial class MonkeysRow : MultiColumnsCell
    {

        // it will be used in the override GetColumnCellTemplate, for columns>2
        // this is not needed its just for this demo
        public DataTemplate CenteredCell { get; set; }

        public MonkeysRow(Type childCell, XamListView list) : base(childCell, list)
        {
            MainGrid.BackgroundColor = Color.WhiteSmoke;

            CenteredCell = new DataTemplate(typeof(MonkeyCellCentered));
        }

        public override void SetupCell()
        {



            base.SetupCell();
        }

        public override DataTemplate GetColumnCellTemplate(int columns)
        {
            if (columns > 2)
                return CenteredCell;

            return base.GetColumnCellTemplate(columns);
        }
    }

}