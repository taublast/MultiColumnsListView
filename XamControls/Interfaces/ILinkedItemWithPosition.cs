using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace AppoMobi.Xam
{


    public interface ILinkedItemWithPosition
    {
        dynamic Prev { get; set; }
        dynamic Next { get; set; }
        int Position { get; set; }
    }




}
