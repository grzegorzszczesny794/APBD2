namespace APBD2
{
    internal sealed class LiquidContainerCargo : ContainerCargo
                                          , IHazarNotifier
    {
        public required bool IsDangerous { get; set; }

        public override void AddWeight(double weight)
        {
            if (((MaxWeight * 0.5) < weight + CargoWeight) && IsDangerous)
            {
                Notify("Materiał jest niebezpieczny i przekroczył 50% dozwolonej wagi.");
                return;
            }

            if ((MaxWeight * 0.9) < weight + CargoWeight)
            {
                Notify("Materiał jest bezpieczny i przekroczył 90% dozwolonej wagi.");
                return;
            }

            base.AddWeight(weight);
        }
         
        public override string GetCargoSerialNumberPrefix() => "L";

        public override void GetInformaction()
        {
            base.GetInformaction();
            Console.WriteLine($"{(IsDangerous ? "Niebezpieczny" : "Bezpieczny")}");
        }

        public void Notify(string message)
        {
           Console.WriteLine(message);
        }


    }
}
