namespace APBD2
{
    internal sealed class ContainerShip : IInformation
    {
        public List<ContainerCargo> CargoList { get; set; } 
        public int MaxSpeed { get; set; }
        public int MaxAmountOfContainer { get; set; }   
        public double MaxWeightOfContainer { get; set; }

        public double ContainerWeight { get => CargoList.Sum(x => x.OwnWeight + x.CargoWeight); }

        public ContainerShip(int maxSpeed, int maxAmountOfContainers, double maxWeightOfContainers)
        {
            MaxSpeed = maxSpeed;
            MaxWeightOfContainer = maxWeightOfContainers;
            MaxAmountOfContainer = maxAmountOfContainers;
            CargoList = new();
        }

        public void AddContainer(ContainerCargo cargo)
        {
            if (CargoList.Count + 1 > MaxAmountOfContainer)
                throw new OverfillException("Zbyt wiele kontenerów");

            if ((cargo.CargoWeight + cargo.OwnWeight + ContainerWeight) > MaxWeightOfContainer)
                throw new OverfillException("Zbyt wielka waga!");

            CargoList.Add(cargo);
        }

        public void Empty() => CargoList.Clear();

        public void DeleteContainer(ContainerCargo cargo) => CargoList.Remove(cargo);

        public void ReplaceContainer(string containerNumber, ContainerCargo cargo) {

            var foundContainer = CargoList.FirstOrDefault(x => x.SerialNumber == containerNumber);

            if (foundContainer is null)
                throw new Exception("Nie odnaleziono kontenera o podanym numerze!");

            CargoList.Remove(foundContainer);
            AddContainer(cargo);
        }

        public void MoveFromShipToAnotherShip(ContainerShip shipTo, ContainerCargo container)
        {
            var foundContainer = CargoList.FirstOrDefault(x => x.SerialNumber == container.SerialNumber);

            if (foundContainer is null)
                throw new Exception("Nie odnaleziono kontenera o podanym numerze!");

            CargoList.Remove(container);

            shipTo.AddContainer(container);
        }

        public void AddContainers(IEnumerable<ContainerCargo> containers) => CargoList.AddRange(containers);

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
