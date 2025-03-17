
using APBD2;

public class Program
{
    public static void Main(string[] args)
    {

        var shipmentManager = new ShipmentManager();

        Console.WriteLine("Shipment manager: ");

        while (true) {

            shipmentManager.ShowAvalaibleShips();

            var line = Console.ReadLine() ?? string.Empty;

            var commands = line.Split(' ').ToList();

            if (!commands.Any())
            {
                Console.WriteLine("Not commands found.");
                continue;
            }    

            switch (commands[0])
            {
                case CommandEnum.REPLACE_CONTAINER_FROM_SHIP:
                    break;
                case CommandEnum.CREATE_CONTAINER:
                    break;
                default:
                    Console.WriteLine("Unknown command"); 
            }

        }

    }
}


