using App16;

internal class Program
{
    private static void Main(string[] args)
    {
     VehicleCatalogue catalogue = new VehicleCatalogue();

        catalogue.Vehicles.Add(new Vehicle("BMW", "X5", 2020, 198548, 27000));
        catalogue.Vehicles.Add(new Vehicle("Chevrolet", "Aveo", 2010, 153000, 1700));
        catalogue.Vehicles.Add(new Vehicle("Volkswagen", "Polo", 2011, 120000,3000));
        catalogue.Vehicles.Add(new Vehicle("Renault", "Megane", 2012, 175000, 3000));
        catalogue.Vehicles.Add(new Vehicle("Opel", "Corsa", 2004, 180000, 3200));
        catalogue.Vehicles.Add(new Vehicle("Mercedes", "GLA", 2020, 20000, 3800));
        catalogue.Vehicles.Add(new Vehicle("Seat", " Noul Leon", 2024, 100, 27000));
        catalogue.Vehicles.Add(new Vehicle("Seat", "Leon", 2006, 200000, 3000));
        catalogue.Vehicles.Add(new Vehicle("Opel", "Zafira", 1999, 245000, -500));

        catalogue.ShowAllVehicles();
    }
}