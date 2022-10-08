using System;
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
            var columns = _list.Columns;
            if (columns < 1) columns = 1;

            _grid.ColumnDefinitions.Clear();
            double myWidth = 100 / (double)columns;

            //Debug.WriteLine($"[CELL] Redrawing to {columns} columns..");
            for (int a = 0; a < columns; a++)
            {
                _grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(myWidth, GridUnitType.Star) });
            }

            var itemTemplate = GetColumnCellTemplate(columns); //new DataTemplate(_childCell));
            var thisItem = item;
            for (int col = 0; col < columns; col++)
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
                    ((XamCell)view).Columns = columns;
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
