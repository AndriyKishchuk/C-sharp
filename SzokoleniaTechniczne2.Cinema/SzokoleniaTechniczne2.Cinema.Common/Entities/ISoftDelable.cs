namespace SzokoleniaTechniczne2.Cinema.Common.Entities
{
    internal interface ISoftDelable
    {
        bool IsDeleted { get; set; }
    }
}
