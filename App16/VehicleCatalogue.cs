
namespace App16
{
    internal class VehicleCatalogue
    {
        public List<Vehicle> Vehicles;

        public VehicleCatalogue()
        {
            Vehicles = new List<Vehicle>();
        }

        public void SortByPrice(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Price).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Price).ToList();
            }
        }

        public void SortByYear(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Year).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Year).ToList();
            }
        }

        public void SortByKm(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Km).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Km).ToList();
            }
        }

        public List<Vehicle> SortByBrand(string brand)
        {
            return Vehicles.FindAll(item => item.Brand == brand);
        }

        public List<Vehicle> SortByModel(string model)
        {
            return Vehicles.FindAll(item => item.Model.ToLower() == model.ToLower());

        }

        public void ShowAllVehicles()
        {
            Console.WriteLine("Available vehicles: ");
            for (int i = 0; i < Vehicles.Count; i++)
            {

                Console.WriteLine((i + 1) + " : " + Vehicles[i].GetData());
            }
        } 
        
        public static void ShowAllVehiclesFromCollection(List<Vehicle> collection)
        {
            Console.WriteLine("Available vehicles: ");
            for (int i = 0; i < collection.Count; i++)
            {

                Console.WriteLine((i + 1) + " : " + collection[i].GetData());
            }
        }
    }
}
