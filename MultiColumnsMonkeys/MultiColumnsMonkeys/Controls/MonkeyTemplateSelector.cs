using AppoMobi.Xam;
using MultiColumnMonkeys.Models;
using MultiColumnMonkeys.Views;
using Xamarin.Forms;

namespace MultiColumnMonkeys.Controls
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
            //todo you can add you own template for OnSelectedTemplate override

        }

        public override DataTemplate OnSelectedTemplate(object item, DataTemplate selected, string desc)
        {
            //assign it here anything instead of multicolumns row, show something totally different,
            // a news slider etc
            // Ex:
            /*
            if (item is Item myItem)
            {
                    if (myItem.Id == "slider")
                    {
                        return NewsSliderTemplate;
                    }
             }
            */
            return selected;
        }
    }

 
}
