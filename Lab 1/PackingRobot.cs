using AutomatedWarehouse;

namespace Lab_1;

class PackingRobot : WarehouseRobot
{
    public PackingRobot(string name) : base(name) { }

    public override void ProcessOrder(Order order)
    {
        order.State = "Packed";
    }
}