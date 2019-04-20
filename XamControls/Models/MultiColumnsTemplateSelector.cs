using System;
using Xamarin.Forms;

namespace AppoMobi.Xam
{
  

   public class MultiColumnsTemplateSelector <T> : DataTemplateSelector where T: class
    {
        public DataTemplate SimpleICell { get; set; }
        public DataTemplate EmptyCell { get; set; }


        private XamListView _parent;
        private Type _multiColumnsCell;
        private Type _multiColumnsCellInRow;
        private Type _simpleCell;
        public DataTemplate MultiColumnsCell { get; set; }

        /// <summary>
        /// todo
        /// </summary>
        /// <param name="parentList">Parent ListView reference</param>
        /// <param name="simpleCell">selected when Columns = 1</param>
        /// <param name="multiColumnsCell">selected when Columns > 1 </param>
        /// <param name="multiColumnsCellInRow">will be used as final cell inside 'multiColumnsCell'</param>
        public MultiColumnsTemplateSelector(
            XamListView parentList, 
            Type simpleCell, 
            Type multiColumnsCell,
            Type multiColumnsCellInRow)
        {
            _simpleCell = simpleCell;
            _parent = parentList;
            _multiColumnsCell = multiColumnsCell;
            _multiColumnsCellInRow = multiColumnsCellInRow;
          
         CreateTemplates();
        }

        public void CreateTemplates()
        {
            EmptyCell = new DataTemplate(() =>
            {
                var cell = new ViewCell();
                var view = new ContentView
                {
                    HeightRequest = 0
                };
                cell.View = view;
                return cell;
            });
            if (_simpleCell != null)
                SimpleICell = new DataTemplate(_simpleCell);
            MultiColumnsCell = new DataTemplate(() =>
            {
                //with throw here if type is not MultiColumnsCell
                var multiCell = (MultiColumnsCell)Activator.CreateInstance(_multiColumnsCell, _multiColumnsCellInRow, _parent);
                return multiCell;
            });
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        { 
             var Columns = _parent.Columns;
            if (Columns > 1 && item is ILinkedItemWithPosition)
            {
                var myItem = item as ILinkedItemWithPosition;

                int cells = Columns;//number of cells per row
                double row = myItem.Position / cells;
                var full = row * cells;
                if (full != myItem.Position)
                {
                    return OnSelectedTemplate(item, EmptyCell, "empty");
                }
         
                return OnSelectedTemplate(item, MultiColumnsCell,"multi");
            }
              
            if (SimpleICell!=null)
                return OnSelectedTemplate(item, SimpleICell, "simple");

            return OnSelectedTemplate(item, MultiColumnsCell, "multi");
        }

        public virtual DataTemplate OnSelectedTemplate(object item, DataTemplate selected,  string desc) // the desc param here is just for your debugging purposes
        {
            return selected;
        }
    }


}
