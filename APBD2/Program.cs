
using APBD2;

var gasolineContainer = new GasolineContainerCargo()
{
    CargoWeight = 2,
    Depth = 3,
    Height = 4,
    MaxWeight = 5,
    OwnWeight = 23
};

var refrigarationContainer = new RefrigerationContainer()
{
    Depth = 3,
    Height = 4,
    MaxWeight = 23,
    CargoWeight = 0,
    OwnWeight = 10,
    Temperature = 22
};

refrigarationContainer.ProductType = ProductType.Bananas;

gasolineContainer.GetInformaction();
gasolineContainer.AddWeight(2);

var liquidContainer = new LiquidContainerCargo()
{
    Depth = 2,
    Height = 23,
    IsDangerous = true,
    OwnWeight = 12,
    MaxWeight = 12,
};

liquidContainer.AddWeight(3);

var ship = new ContainerShip()
{
    MaxAmountOfContainer = 10,
    MaxSpeed = 23,
    MaxWeightOfContainer = 1000,
};

ship.AddContainer(liquidContainer);
ship.AddContainers([gasolineContainer, refrigarationContainer]);

var ship2 = new ContainerShip()
{
    MaxAmountOfContainer = 2,
    MaxSpeed = 2,
    MaxWeightOfContainer = 3
};

ship.GetInformation();