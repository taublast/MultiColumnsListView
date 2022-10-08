namespace AppoMobi.Xam
{


    public interface ILinkedItemWithPosition
    {
        ILinkedItemWithPosition Prev { get; set; }
        ILinkedItemWithPosition Next { get; set; }
        int Position { get; set; }
    }




}
