namespace APBD2
{
    internal sealed class RefrigerationContainer : ContainerCargo
                                                , IHazarNotifier
    {
        private ProductType _productType;
        public  ProductType ProductType
        {
            get { return _productType; }
            set
            {
                if (Temperature < ProductTemperature.GetTemperature(value))
                    throw new Exception("Temperatura za niska");
                _productType = value;
            }
        }

        public double Temperature { get; set; } = 0;

        public void AddWeight(double weight, ProductType productType)
        {
            if (Temperature < ProductTemperature.GetTemperature(productType))
                throw new Exception("Temperatura za niska");

            if (productType != _productType)
                throw new Exception("Produkt nieprawidłowy");

            AddWeight(weight);
        }

        public override string GetCargoSerialNumberPrefix() => "R";

        public override void GetInformaction()
        {
            base.GetInformaction();
            Console.WriteLine($"ProductType: {nameof(ProductType)}");
        }

        public void Notify(string message) => Console.WriteLine(message + $"Numer kontenera: {SerialNumber}");

    }
}
