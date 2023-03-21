namespace IronHelmOrderSystem.Models
{
    public interface IOrderItemModel
    {
        int OrderItemID { get; set; }

        string Name { get; set; }

        int Quantity { get; set; }

        string Description { get; set; }

        byte[] Artwork { get; set; }

        int HoursRequired { get; set; }

        float Price { get; set; }
    }
}