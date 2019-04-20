using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;


namespace AppoMobi.Xam
{
    public class XamObservableCollection<T> : ObservableCollection<T>
    {
        //-----------------------------------------------------------------------------------------------------------
        public XamObservableCollection()
        //-----------------------------------------------------------------------------------------------------------
        {

        }


        //-----------------------------------------------------------------------------------------------------------
        public void ReportItemChange(T item)
        //-----------------------------------------------------------------------------------------------------------
        {
            NotifyCollectionChangedEventArgs args =
                new NotifyCollectionChangedEventArgs(
                    NotifyCollectionChangedAction.Replace,
                    item,
                    item,
                    IndexOf(item));
            OnCollectionChanged(args);
        }

        //---------------------------------------------------------------------------------------------------------
        public void RefreshRange(int index, int quantity)
        //---------------------------------------------------------------------------------------------------------
        {
            CheckReentrancy();
            var changedItems = new List<T>();
            for (var currentIndex = index; currentIndex < quantity + index; currentIndex++)
            {
                try
                {
                    changedItems.Add(Items[currentIndex]);
                }
                catch
                {
                    break;
                }
            }
            // OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, changedItems, changedItems, index));
        }

        //---------------------------------------------------------------------------------------------------------
        public void RefreshRange(int index, IEnumerable<T> collection)
        //---------------------------------------------------------------------------------------------------------
        {
            CheckReentrancy();
            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);

            for (var currentIndex = index; currentIndex < changedItems.Count + index; currentIndex++)
            {
                try
                {
                    var i = changedItems[currentIndex];
                    Items.RemoveAt(currentIndex); //remove
                    Items.Insert(currentIndex, i); //insert new 
                }
                catch
                {
                    break;
                }
            }

            // OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, changedItems, changedItems, index));
        }

        //---------------------------------------------------------------------------------------------------------
        public void InsertRange(int index, IEnumerable<T> collection)
        //---------------------------------------------------------------------------------------------------------
        {
            //NotifyCollectionChangedAction notificationMode = NotifyCollectionChangedAction.Add;

            CheckReentrancy();

            int currentIndex = index;
            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);
            foreach (var i in changedItems)
            {
                Items.Insert(currentIndex, i);
                currentIndex++;
            }
            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, changedItems, index));
        }

    }

}

