
using APBD2;

var gasolineContainer = new GasolineContainerCargo(12, 12.0, 2, 30.0);
var gasolineContainer2 = new GasolineContainerCargo(12, 11.0, 2, 24.0);

gasolineContainer.AddWeight(23.0);
gasolineContainer2.AddWeight(21.0);
gasolineContainer.GetInformaction();
gasolineContainer.AddWeight(2);

var refrigarationContainer = new RefrigerationContainer(12, 12.0, 2, 30.0, ProductType.Bananas, 16);

refrigarationContainer.ProductType = ProductType.Bananas;
refrigarationContainer.AddWeight(12, ProductType.Bananas);

var liquidContainer = new LiquidContainerCargo(12, 12.4, 2, 38.0, true);
liquidContainer.AddWeight(3);
liquidContainer.EmptyCargo();

try
{
    liquidContainer.AddWeight(2323.0);
} catch { }

liquidContainer.AddWeight(2);

var ship = new ContainerShip(12, 10, 602.0);

ship.AddContainer(liquidContainer);
ship.AddContainers([gasolineContainer, refrigarationContainer]);

var ship2 = new ContainerShip(43, 23, 122.3);
ship2.AddContainer(gasolineContainer2);

ship2.GetInformation();
ship.GetInformation();

ship.DeleteContainer(gasolineContainer);
ship.ReplaceContainer(refrigarationContainer.SerialNumber, gasolineContainer);

ship2.MoveFromShipToAnotherShip(ship, gasolineContainer2);

ship.GetInformation();