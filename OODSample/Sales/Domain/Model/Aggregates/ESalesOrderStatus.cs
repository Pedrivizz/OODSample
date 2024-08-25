namespace OODSample.Sales.Domain.Model.Aggregates;

public enum ESalesOrderStatus
{
    Cancelled,
    PendingPayment,
    ReadyForShipment,
    Shipped,
    Completed
}