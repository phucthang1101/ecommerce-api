namespace API.Entities.OrderAggregate
{
    //An enum is a special "class" that represents a group of constants 
    public enum OrderStatus
    {
        Pending, 
        PaymentReceived,
        PaymentFailed
    }
}
