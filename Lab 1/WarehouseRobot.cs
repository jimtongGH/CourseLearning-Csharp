using Lab_1;

namespace AutomatedWarehouse
{
    abstract class WarehouseRobot
    {
        private string _name;
    
        public string Name
        {
            get => _name;
            set => _name = string.IsNullOrEmpty(value) ? "Warehouse Robot" : value;
        }
    
        public WarehouseRobot(string name)
        {
            Name = name;
        }

        public abstract void ProcessOrder(Order order);
    }
}