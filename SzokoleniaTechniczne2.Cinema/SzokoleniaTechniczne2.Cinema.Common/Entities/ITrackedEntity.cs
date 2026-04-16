namespace SzokoleniaTechniczne2.Cinema.Common.Entities
{
    internal interface ITrackedEntity
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        Guid CreatedByUserId { get; set; }
        Guid ModifiedByUserId { get; set; }
    }
}
