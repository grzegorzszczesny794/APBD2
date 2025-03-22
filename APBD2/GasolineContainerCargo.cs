namespace APBD2
{
    internal sealed class GasolineContainerCargo : ContainerCargo
                                                 , IHazarNotifier
    {
        public GasolineContainerCargo(int height
                                    , double ownWeight
                                    , int depth
                                    , double maxWeight) : base(height, ownWeight, depth, maxWeight) { }

        public override void EmptyCargo() => CargoWeight = CargoWeight * 0.05;

        public void Notify(string message) => Console.WriteLine($"{message}, Numer: {SerialNumber}");

        public override void GetInformaction()
        {
            base.GetInformaction();
            Console.WriteLine("Typ kontenera: Gazowy");
        }

        protected override string GetCargoSerialNumberPrefix() => "G";
        
    }
}
