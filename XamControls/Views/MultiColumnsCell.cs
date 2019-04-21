using System;
using System.Diagnostics;
using AppoMobi.Xam;
using Xamarin.Forms;

namespace AppoMobi.Xam
{
 public class MultiColumnsCell : ViewCell
    {
 
        protected Xamarin.Forms.Grid _grid;
        private Type _childCell;
        private XamListView _list;

        //---------------------------------------------------------------------------------------------------------------
        public MultiColumnsCell(Type childCell, XamListView list)
       //---------------------------------------------------------------------------------------------------------------
        {
            _list = list;
            _childCell = childCell;
            _grid = new Xamarin.Forms.Grid
            {
                ColumnSpacing = 0, 
                VerticalOptions = LayoutOptions.Fill
            };
            View = _grid;
        }
   

        public Xamarin.Forms.Grid MainGrid
        {
            get
            {
                return _grid;
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is ILinkedItemWithPosition)
            {
                BuildCell();
                SetupCell();
            }
        }

        public virtual void SetupCell()
        {

        }

        protected void BuildCell()
        {
            var item = BindingContext as ILinkedItemWithPosition;
         
            _grid.ColumnDefinitions.Clear();
            double myWidth = 100 / (double)_list.Columns;
            Debug.WriteLine($"[CELL] Redrawing to {_list.Columns} columns..");
            for (int a = 0; a < _list.Columns; a++)
            {
                _grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(myWidth, GridUnitType.Star) });
            }

            var itemTemplate = GetColumnCellTemplate(_list.Columns); //new DataTemplate(_childCell));
            var thisItem = item;
            for (int col = 0; col < _list.Columns; col++)
            {
                if (thisItem == null)
                {
                    //we have no item for this cell...
                    //todo
                    break;
                }
                var view = (View)itemTemplate.CreateContent();
                if (view is XamCell)
                {
                    ((XamCell) view).Columns = _list.Columns;
                }
                var bindableObject = view as BindableObject;
                if (bindableObject != null)
                    bindableObject.BindingContext = thisItem; // send data to item 
                _grid.Children.Add(view, col, 0);
                thisItem = thisItem.Next;
                //Task.Delay(1);
            }
            SetupCell();
        }

        public virtual DataTemplate GetColumnCellTemplate(int columns)
        {
            return new DataTemplate(_childCell);
        }
    }
 

}
