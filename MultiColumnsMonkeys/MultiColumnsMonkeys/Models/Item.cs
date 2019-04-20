using System;
using AppoMobi.Xam;

namespace MultiColumnsMonkeys.Models
{
    public class Item : ILinkedItemWithPosition
    {

        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
 
        //URL for our monkey image!
        public string Image { get; set; }

        #region LinkedItem
        public dynamic Prev { get; set; }
        public dynamic Next { get; set; }
        public int Position { get; set; }
        #endregion

        #region Groupping

        public string NameSort => Text[0].ToString();
        
        #endregion
    }
}