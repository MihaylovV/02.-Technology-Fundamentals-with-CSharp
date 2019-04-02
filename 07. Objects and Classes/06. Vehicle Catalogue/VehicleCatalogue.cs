using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Vehicle_Catalogue
{
    class Vehicle
    {
        // fields
        string vehicleType = null;
        string vehicleModel = null;
        string vehicleColor = null;
        double vehicleHorsepower = 0;

        public static List<Vehicle> listOfAllVehicles = new List<Vehicle>();
        public static List<Vehicle> listOfCars = new List<Vehicle>();
        public static List<Vehicle> listOfTrucks = new List<Vehicle>();

        // constructor
        public Vehicle(string vehicleType, string vehicleModel, string vehicleColor, double vehicleHorsepower)
        {
            this.vehicleType = vehicleType;
            this.vehicleModel = vehicleModel;
            this.vehicleColor = vehicleColor;
            this.vehicleHorsepower = vehicleHorsepower;
        }

        // methods
        public static void PrintVehicleInfo(string model)
        {
            for (int i = 0; i < listOfAllVehicles.Count; i++)
            {
                if (listOfAllVehicles[i].vehicleModel == model)
                {
                    Console.WriteLine("Type: {0}", listOfAllVehicles[i].vehicleType);
                    Console.WriteLine("Model: {0}", listOfAllVehicles[i].vehicleModel);
                    Console.WriteLine("Color: {0}", listOfAllVehicles[i].vehicleColor);
                    Console.WriteLine("Horsepower: {0}", listOfAllVehicles[i].vehicleHorsepower);
                    break;
                }
            }
        }

        public static void PrintAverageHorsepowerCars()
        {
            if (listOfCars.Count == 0)
            {
                Console.WriteLine("Cars have average horsepower of: 0");
            }
            else
            {
                double sum = 0;
                foreach (Vehicle car in listOfCars)
                {
                    sum += car.vehicleHorsepower;
                }

                Console.WriteLine("Cars have average horsepower of: {0:F2}.", sum / listOfCars.Count);
            }
        }

        public static void PrintAverageHorsepowerTrucks()
        {
            if (listOfTrucks.Count == 0)
            {
                Console.WriteLine("Trucks have average horsepower of: 0");
            }
            else
            {
                double sum = 0;
                foreach (Vehicle truck in listOfTrucks)
                {
                    sum += truck.vehicleHorsepower;
                }

                Console.WriteLine("Trucks have average horsepower of: {0:F2}.", sum / listOfTrucks.Count);
            }
        }
    }

    class VehicleCatalogue
    {
        static void Main()
        {
            GetVehicleInfoFromUser();
            PrintVehiclesByModel();
            Vehicle.PrintAverageHorsepowerCars();
            Vehicle.PrintAverageHorsepowerTrucks();
        }

        static void GetVehicleInfoFromUser()
        {
            bool isWorking = true;
            while (isWorking == true)
            {
                string input = Console.ReadLine();
                char[] separators = new char[] { ' ' };
                string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (inputArray[0] == "car")
                {
                    Vehicle.listOfCars.Add(new Vehicle("Car", inputArray[1], inputArray[2], double.Parse(inputArray[3])));
                    Vehicle.listOfAllVehicles.Add(new Vehicle("Car", inputArray[1], inputArray[2], double.Parse(inputArray[3])));
                }
                else if (inputArray[0] == "truck")
                {
                    Vehicle.listOfTrucks.Add(new Vehicle("Truck", inputArray[1], inputArray[2], double.Parse(inputArray[3])));
                    Vehicle.listOfAllVehicles.Add(new Vehicle("Truck", inputArray[1], inputArray[2], double.Parse(inputArray[3])));
                }
                else if (inputArray[0] == "End")
                {
                    isWorking = false;
                }
            }
        }

        static void PrintVehiclesByModel()
        {
            bool isWorking = true;
            while (isWorking == true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    isWorking = false;
                }
                else
                {
                    Vehicle.PrintVehicleInfo(model);
                }
            }
        }
    }
}
