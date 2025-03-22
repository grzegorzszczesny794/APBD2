namespace APBD2
{
    internal sealed class LiquidContainerCargo : ContainerCargo
                                          , IHazarNotifier
    {

        public bool IsDangerous { get; set; }

        public LiquidContainerCargo(int height
                                  , double ownWeight
                                  , int depth
                                  , double maxWeight
                                  , bool isDangerous) : base(height, ownWeight, depth, maxWeight)
        {
            IsDangerous = isDangerous;
        }

        public override void AddWeight(double weight)
        {
            if (((MaxWeight * 0.5) < (weight + CargoWeight)) && IsDangerous)
            {
                Notify($"Materiał jest niebezpieczny i przekroczył 50% dozwolonej wagi, kontener o numerze: {SerialNumber}");
                throw new OverfillException($"Cannot load {weight}kg. Maximum allowed is {MaxWeight}kg.");
            }

            if ((MaxWeight * 0.9) < (weight + CargoWeight))
            {
                Notify($"Materiał jest bezpieczny i przekroczył 90% dozwolonej wagi, kontener o numerze: {SerialNumber}");
                throw new OverfillException();
            }

            base.AddWeight(weight);
        }

        protected override string GetCargoSerialNumberPrefix() => "L";

        public override void GetInformaction()
        {
            base.GetInformaction();
            Console.WriteLine($"{(IsDangerous ? "Niebezpieczny" : "Bezpieczny")}");
            Console.WriteLine($"Typ kontenera: Płyn");
        }

        public void Notify(string message) => Console.WriteLine($"{message}, Numer: {SerialNumber}");

    }
}
