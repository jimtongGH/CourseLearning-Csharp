using AutomatedWarehouse;

namespace Lab_1;

class DispatchRobot : WarehouseRobot
{
    public DispatchRobot(string name) : base(name) { }
    
    public override void ProcessOrder(Order order)
    {
        order.State = "Dispatched";
    }
}