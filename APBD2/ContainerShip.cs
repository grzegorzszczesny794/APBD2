namespace APBD2
{
    internal sealed class ContainerShip : IInformation
    {
        public List<ContainerCargo> CargoList { get; set; } = new();
        public int MaxSpeed { get; set; }
        public int MaxAmountOfContainer { get; set; }   
        public double MaxWeightOfContainer { get; set; }

        public void GetInformation()
        {
            Console.WriteLine($"Container ship information");

            Console.WriteLine($"Max speed = {MaxSpeed}");
            Console.WriteLine($"Max amount of container = {MaxAmountOfContainer}");
            Console.WriteLine($"Max weight of container = {MaxWeightOfContainer}");

            CargoList.ForEach(c => c.GetInformaction());
        }
    }
}
