namespace APBD2
{
    internal abstract class ContainerCargo
    {
        public required double CargoWeight { get; set; }
        public required int Height { get; set; }
        public required double Weight { get; set; }
        public required int Depth { get; set; }
        public string SerialNumber { get; set; }
        public required double MaxWeight { get; set; }

        public virtual void EmptyCargo() => CargoWeight = 0;
        public virtual void AddWeight(double weight)
        {
            if (CargoWeight + weight > MaxWeight) throw new OverfillException((CargoWeight + weight).ToString());
            
            CargoWeight += weight;
        }

        public ContainerCargo() => SerialNumber = $"KON-{GetCargoSerialNumberPrefix() + "-" + new Random().Next()}";

        public virtual string  GetCargoSerialNumberPrefix() => "C";

        public virtual void GetInformaction()
        {
            Console.WriteLine("=== Informacje o kontenerze ===");
            Console.WriteLine($"Numer seryjny: {SerialNumber}");
            Console.WriteLine($"Wymiary: {Height}cm x {Depth}cm");
            Console.WriteLine($"Waga kontenera: {Weight}kg");
            Console.WriteLine($"Aktualna waga ładunku: {CargoWeight}kg");
            Console.WriteLine($"Maksymalna waga ładunku: {MaxWeight}kg");
            Console.WriteLine($"Dostępna przestrzeń: {(MaxWeight - CargoWeight)}kg");
            Console.WriteLine($"Wypełnienie: {(CargoWeight / MaxWeight * 100):F2}%");
        }

    }

}
