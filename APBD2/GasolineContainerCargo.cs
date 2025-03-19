namespace APBD2
{
    internal sealed class GasolineContainerCargo : ContainerCargo
                                                 , IHazarNotifier
    {
        public override void EmptyCargo() => CargoWeight = CargoWeight * 0.05;

        public void Notify(string message) => Console.WriteLine(message);
       
        public override void GetInformaction() => base.GetInformaction();

        public override string GetCargoSerialNumberPrefix() => "G";
        
    }
}
