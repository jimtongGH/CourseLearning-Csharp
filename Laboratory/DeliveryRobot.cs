using AutomatedWarehouse;

namespace Laboratory;

class DeliveryRobot : WarehouseRobot
{
    public DeliveryRobot(string name) : base(name) { }
    
    public override void ProcessOrder(Order order)
    {
        order.State = "Delivered";
    }
}