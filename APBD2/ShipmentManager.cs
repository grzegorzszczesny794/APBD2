namespace APBD2
{
    internal sealed class ShipmentManager
    {
        public void AssignContainerToShip(ContainerShip ship, ContainerCargo cargo) => ship.CargoList.Add(cargo);
        public void AssignContainersToShip(ContainerShip ship, IEnumerable<ContainerCargo> cargos) => ship.CargoList.AddRange(cargos);

        public void AssignCargoToContainer(double weight,  ContainerCargo cargo) => cargo.AddWeight(weight);

        public void DeleteContainerFromShip(ContainerShip ship, ContainerCargo cargo) => ship.CargoList?.Remove(cargo);

        public void EmptyContainer(ContainerCargo cargo) => cargo.EmptyCargo();

        public void ReplaceContainer(string containerNumber, ContainerCargo cargo, ContainerShip ship)
        {
            var foundContainer = ship.CargoList.FirstOrDefault(x => x.SerialNumber ==  containerNumber);

            if (foundContainer is null)
                throw new Exception();

            ship.CargoList.Remove(foundContainer);
            ship.CargoList.Add(cargo);
        }

        public void MoveFromShipToAnotherShip(ContainerShip shipFrom, ContainerShip shipTo, ContainerCargo container)
        {
            var foundContainer = shipFrom.CargoList.FirstOrDefault(x => x.SerialNumber == container.SerialNumber);

            if (foundContainer is null)
                throw new Exception();

            shipFrom.CargoList.Remove(container);


            shipTo.CargoList.Add(container);
        }

        public void GetContainerInfo(ContainerCargo cargo) { 
        }

    }
}
