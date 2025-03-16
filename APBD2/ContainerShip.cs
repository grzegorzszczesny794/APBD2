namespace APBD2
{
    internal sealed class ContainerShip
    {
        public List<ContainerCargo> CargoList { get; set; } = new();
        public int MaxSpeed { get; set; }
        public int MaxAmountOfContainer { get; set; }   
        public double MaxWeightOfContainer { get; set; }
    }
}
