using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    internal class VehicleCatalogue
    {
        public List<Vehicle> Vehicles;

        public VehicleCatalogue()
        {
            Vehicles = new List<Vehicle>();
        }

        public void SortByPrice()
        {

        }

        public void SortByYear()
        {

        }

        public void SortByKm()
        {

        }

        public void SortByBrand()
        {

        }

        public void SortByModel()
        {

        }

        public void ShowAllVehicles()
        {
            Console.WriteLine("Available vehicles: ");
            for (int i = 0; i < Vehicles.Count; i++)
            {

                Console.WriteLine((i + 1) + " : " + Vehicles[i].GetData());
            }
        }
    }
}
