using System;
using AppoMobi.Xam;
using Xamarin.Forms;

namespace MultiColumnMonkeys.Controls
{
    // when subclassed set your preferred caching strategy/other options for appropriate list

    public class MonkeysListView : XamListView
    {

        //---------------------------------------------------------------------------------------------------------
        public MonkeysListView(): base(SelectCachingStrategy())
        //---------------------------------------------------------------------------------------------------------
        {
            ItemTemplate = new MonkeyTemplateSelector(this);

            SeparatorVisibility = SeparatorVisibility.None;
            HasUnevenRows = true;
            IsGroupingEnabled = false;
        }


        public void CreateTemplates()
        {
            ((MonkeyTemplateSelector)ItemTemplate).CreateTemplates();
        }

        static ListViewCachingStrategy SelectCachingStrategy()
        {
            switch (Device.RuntimePlatform)
            {

                case Device.Android:
                    return ListViewCachingStrategy.RetainElement; //RecycleElement
                case Device.iOS:
                    return ListViewCachingStrategy.RetainElement; //RecycleElement
                default:
                    return ListViewCachingStrategy.RetainElement; //RecycleElement

            }
        }

    }



}
