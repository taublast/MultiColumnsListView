using AppoMobi.Xam;
using System;

namespace MultiColumnMonkeys.Models
{
    public class Item : ILinkedItemWithPosition
    {
        public Item()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        //URL for our monkey image!
        public string Image { get; set; }

        #region LinkedItem
        public ILinkedItemWithPosition Prev { get; set; }
        public ILinkedItemWithPosition Next { get; set; }
        public int Position { get; set; }
        #endregion

        #region Groupping

        public string NameSort => Text[0].ToString();

        #endregion
    }
}