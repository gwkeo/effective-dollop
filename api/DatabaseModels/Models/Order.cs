namespace DatabaseModels.Models;

public class Order(
    Guid id,
    Guid userId,
    string addressFrom,
    string addressTo,
    List<Guid> productsIds,
    DateTime dateTimeOrdered,
    DateTime dateTimeDelivered
    )
{
    public Guid Id { get; set; } = id;

    public Guid UserId { get; set; } = userId;

    public string AddressFrom { get; set; } = addressFrom;

    public string AddressTo { get; set; } = addressTo;

    public List<Guid> ProductsIds { get; set; } = productsIds;

    public DateTime DateTimeOrdered { get; set; } = dateTimeOrdered;

    public DateTime DateTimeDelivered { get; set; } = dateTimeDelivered;
}