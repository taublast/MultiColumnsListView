using Xamarin.Forms;

namespace AppoMobi.Xam
{
    public class XamListView : ListView
    {

        private const string nameColumns = "Columns";
        public static readonly BindableProperty ColumnsProperty =
            BindableProperty.Create(nameColumns, typeof(int), typeof(XamListView), 1); //, BindingMode.TwoWay
        public int Columns
        {
            get { return (int) GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }      

        public XamListView() : base(ListViewCachingStrategy.RecycleElement)
        {
            Init();
        }

        public XamListView(ListViewCachingStrategy strategy) : base(strategy)
        {
            Init();
        }

        protected void Init()
        {
             //todo at will
        }

    }
}
