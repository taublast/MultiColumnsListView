using AppoMobi.Xam;
using MultiColumnsMonkeys.Models;
using MultiColumnsMonkeys.Views;
using Xamarin.Forms;

namespace MultiColumnsMonkeys.Controls
{
    // when subclassed you can have access to OnSelectedTemplate override
    public class MonkeyTemplateSelector : MultiColumnsTemplateSelector<Item>
    {
      
        public MonkeyTemplateSelector(XamListView parentList) : base(
            parentList, 
            null, //unused, we will always use our multiColumnCell even with Columns = 1, otherwise set for 1 column case
            typeof(MonkeysRow),
            typeof(CellMonkey))
        {
            //todo you can add you own template

        }
   
        public override DataTemplate OnSelectedTemplate(object item, DataTemplate selected, string desc)
        {
            //todo and assign it here if anything
            // Ex:
            /*
            if (item is Item myItem)
            {
                    if (myItem.Id == "lol")
                    {
                        return YourSpecialTemplate;
                    }
             }
            */
            return selected;
        }
    }

 
}
