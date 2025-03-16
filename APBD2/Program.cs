
using APBD2;

public class Program
{
    public static void Main(string[] args)
    {

        var container = new ContainerCargo()
        {
            CargoWeight = 1,
            Depth = 1,
            Height = 12,
            MaxWeight = 1,
            SerialNumber = "POC-12",
            Weight = 2.2
        };

        container.EmptyCargo();


    }
}


