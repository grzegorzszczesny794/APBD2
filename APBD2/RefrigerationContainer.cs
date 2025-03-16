namespace APBD2
{
    internal sealed class RefrigerationContainer : ContainerCargo, IHazarNotifier
    {
        private ProductType _productType;
        public ProductType ProductType
        {
            get { return _productType; }
            set
            {
                if (Temperature < ProductTemperature.GetTemperature(value))
                    throw new Exception("Temperatura za niska");
                _productType = value;
            }
        }

        public required double Temperature { get; set; }  

        public void Notify(string message)
        {
            throw new NotImplementedException();
        }
    }
}
