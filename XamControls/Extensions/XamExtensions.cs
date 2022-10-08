using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AppoMobi.Xam
{
    public static class XamExtensions
    {
        public static void NotifyRowChanged<T>(this XamObservableCollection<T> list, T item, int columns) where T : ILinkedItemWithPosition
        {

            var prev = item.Prev;
            if (prev != null)
            {
                double row = item.Position / columns;
                var full = row * columns;
                if (full != item.Position)
                {
                    var size = 2;
                    var firstInRow = false;
                    var maybeFirst = prev;
                    var error = false; ;
                    while (!firstInRow)
                    {
                        var tmpRow = maybeFirst.Position / columns;
                        var tmpFull = tmpRow * columns;
                        if (tmpFull == maybeFirst.Position)
                        {
                            firstInRow = true;
                        }
                        else
                        {
                            maybeFirst = maybeFirst.Prev;
                            if (maybeFirst == null)
                            {
                                //ooops
                                firstInRow = true;
                                error = true;
                            }
                            else
                            {
                                size++;
                            }
                        }
                    }
                    if (!error)
                        list.RefreshRange(maybeFirst.Position, size);
                }
            }


        }

        public static void LinkItemsSetPositions<T>(this IEnumerable<T> list) where T : ILinkedItemWithPosition
        {
            ILinkedItemWithPosition prev = null;
            ILinkedItemWithPosition lastItem = null;
            var pos = 0;

            foreach (var item in list)
            {
                item.Position = pos;
                pos++;
                if (lastItem != null)
                    lastItem.Next = item;
                item.Prev = prev;
                prev = item;
                lastItem = item;
            }
        }

        public static void AddItemLinkSetPosition<T>(this List<T> list, T item) where T : ILinkedItemWithPosition
        {
            item.Position = list.Count();
            var lastItem = list.LastOrDefault();
            if (lastItem != null)
                lastItem.Next = item;
            item.Prev = lastItem;
            list.Add(item);
        }

        public static void AddItemLinkSetPosition<T>(this ObservableCollection<T> list, T item) where T : ILinkedItemWithPosition
        {
            item.Position = list.Count();
            var lastItem = list.LastOrDefault();
            if (lastItem != null)
                lastItem.Next = item;
            item.Prev = lastItem;
            list.Add(item);
        }


    }


}
