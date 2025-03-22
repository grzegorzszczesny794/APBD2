namespace APBD2
{
    internal sealed class RefrigerationContainer : ContainerCargo
    {
        private ProductType _productType;

        public RefrigerationContainer(int height
                                    , double ownWeight
                                    , int depth
                                    , double maxWeight
                                    , ProductType productType
                                    , int temperatura) : base(height, ownWeight, depth, maxWeight)
        {
            if (temperatura < ProductTemperature.GetTemperature(productType))
                throw new Exception("Temperatura nieprawidłowa");

            Temperature = temperatura;
            _productType = productType;
        }

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

        public double Temperature { get; }

        public void AddWeight(double weight, ProductType productType)
        {
            if (productType != _productType)
                throw new Exception("Produkt nieprawidłowy");

            if (Temperature < ProductTemperature.GetTemperature(productType))
                throw new Exception("Temperatura za niska");

            base.AddWeight(weight);
        }

        public override void AddWeight(double weight) => throw new NotImplementedException();

        protected override string GetCargoSerialNumberPrefix() => "R";

        public override void GetInformaction()
        {
            base.GetInformaction();
            Console.WriteLine($"Typ produktu: {nameof(ProductType)}");
            Console.WriteLine($"Temperatura : {Temperature}");
        }
    }
}
