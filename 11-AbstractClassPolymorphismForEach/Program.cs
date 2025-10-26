using System;
using System.Collections.Generic;
using System.Linq;
namespace TransportManagement
{
    // Base class
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }  // 0-100 arası
        // Constructor
        public Vehicle(string brand, string model, int year, string plateNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100.0;   // default olaraq 100
        }
        // Abstract method
        public abstract string GetVehicleInfo();
        // Virtual method
        public virtual void ShowBasicInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, FuelLevel: {FuelLevel:F2}%");
        }
    }
    // Car class
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }  // litrlə
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }  // km/saat
        public Car(string brand, string model, int year, string plateNumber,
                   int doorsCount, int trunkCapacity, bool isAutomatic, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.DoorsCount = doorsCount;
            this.TrunkCapacity = trunkCapacity;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
        }
        public override string GetVehicleInfo()
        {
            return $"Car → Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Doors: {DoorsCount}, Trunk: {TrunkCapacity}L, Automatic: {IsAutomatic}, MaxSpeed: {MaxSpeed} km/h, FuelLevel: {FuelLevel:F2}%";
        }
        public void ShowCarInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
        public double CalculateFuelCost(double distance)
        {
            // Sərfiyyat: 8 litr / 100 km
            // 1 litr yanacaq: 1.50 AZN
            double liters = (distance / 100.0) * 8.0;
            double cost = liters * 1.50;
            return cost;
        }
    }
    // Motorcycle class
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }  // cc
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }  // “Sport”, “Cruiser”, “Touring”
        public Motorcycle(string brand, string model, int year, string plateNumber,
                          int engineCapacity, bool hasSidecar, int maxSpeed, string type)
            : base(brand, model, year, plateNumber)
        {
            this.EngineCapacity = engineCapacity;
            this.HasSidecar = hasSidecar;
            this.MaxSpeed = maxSpeed;
            this.Type = type;
        }
        public override string GetVehicleInfo()
        {
            return $"Motorcycle → Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Engine: {EngineCapacity}cc, Sidecar: {HasSidecar}, Type: {Type}, MaxSpeed: {MaxSpeed} km/h, FuelLevel: {FuelLevel:F2}%";
        }
        public void ShowMotorcycleInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
        public double CalculateFuelCost(double distance)
        {
            // Sərfiyyat: 4 litr / 100 km
            // 1 litr yanacaq: 1.50 AZN
            double liters = (distance / 100.0) * 4.0;
            double cost = liters * 1.50;
            return cost;
        }
    }
    // Truck class
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }  // ton
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }    // ton
        public int MaxSpeed { get; set; }
        public Truck(string brand, string model, int year, string plateNumber,
                     double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = cargoCapacity;
            this.AxleCount = axleCount;
            this.CurrentLoad = currentLoad;
            this.MaxSpeed = maxSpeed;
        }
        public override string GetVehicleInfo()
        {
            return $"Truck → Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, CargoCapacity: {CargoCapacity} ton, Axles: {AxleCount}, CurrentLoad: {CurrentLoad} ton, MaxSpeed: {MaxSpeed} km/h, FuelLevel: {FuelLevel:F2}%";
        }
        public void ShowTruckInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
        public bool LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                return true;  }
            else
            {  Console.WriteLine($"Cannot load {weight} ton. Exceeds capacity of {CargoCapacity} ton.");
                return false;  } }
        public double CalculateFuelCost(double distance)
        {
            // Əsas sərfiyyat: 25 litr / 100 km
            // Yük hər ton üçün: +2 litr / 100 km
            // 1 litr yanacaq: 1.80 AZN
            double liters = (distance / 100.0) * (25.0 + (CurrentLoad * 2.0));
            double cost = liters * 1.80;
            return cost;  } }
    // Program class
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 3 Car obyekti
            Car car1 = new Car("Mercedes", "E200", 2023, "BA1234", 4, 500, true, 220);
            Car car2 = new Car("BMW", "320i", 2022, "BA2345", 4, 480, true, 235);
            Car car3 = new Car("Toyota", "Camry", 2021, "BA3456", 4, 524, true, 210);

            // 2. 2 Motorcycle obyekti
            Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "BA4567", 998, false, 299, "Sport");
            Motorcycle moto2 = new Motorcycle("Harley-Davidson", "TouringModel", 2022, "BA5678", 1868, true, 180, "Cruiser");

            // 3. 2 Truck obyekti
            Truck truck1 = new Truck("MAN", "TGX", 2020, "BA6789", 18.0, 3, 12.0, 120);
            Truck truck2 = new Truck("Volvo", "FH16", 2021, "BA7890", 25.0, 4, 18.0, 110);

            // 4. Hər bir obyektin məlumatlarını göstərin:
            // Avtomobillər üçün:
            List<Vehicle> vehicles = new List<Vehicle> { car1, car2, car3, moto1, moto2, truck1, truck2 };

            Console.WriteLine("=== Cars ===");
            foreach (var car in new List<Car> { car1, car2, car3 })
            {
                car.ShowCarInfo();
                double cost = car.CalculateFuelCost(500);
                Console.WriteLine($"Fuel cost for 500 km: {cost:F2} AZN");
                Console.WriteLine();
            }
            Console.WriteLine("=== Motorcycles ===");
            foreach (var moto in new List<Motorcycle> { moto1, moto2 })
            {
                moto.ShowMotorcycleInfo();
                double cost = moto.CalculateFuelCost(300);
                Console.WriteLine($"Fuel cost for 300 km: {cost:F2} AZN");
                Console.WriteLine();
            }
            Console.WriteLine("=== Trucks ===");
            foreach (var tr in new List<Truck> { truck1, truck2 })
            {
                tr.ShowTruckInfo();
                double cost = tr.CalculateFuelCost(800);
                Console.WriteLine($"Fuel cost for 800 km: {cost:F2} AZN");
                Console.WriteLine();
            }
            // 5. Truck-a yük əlavə edin: Birinci truck-a 5 ton əlavə yükləyin
            Console.WriteLine("Adding 5 ton load to Truck1:");
            bool loaded = truck1.LoadCargo(5.0);
            if (loaded)
            {
                Console.WriteLine("Load added successfully.");
                double newCost = truck1.CalculateFuelCost(800);
                Console.WriteLine($"New fuel cost for 800 km: {newCost:F2} AZN");
            }
            Console.WriteLine();
            // 6. Statistika göstərin:
            Console.WriteLine("=== Statistics ===");
            int totalVehicles = vehicles.Count;
            Console.WriteLine($"Total number of vehicles: {totalVehicles}");

            double averageMaxSpeed = vehicles.Average(v =>
            {
                if (v is Car c) return c.MaxSpeed;
                if (v is Motorcycle m) return m.MaxSpeed;
                if (v is Truck t) return t.MaxSpeed;
                return 0;
            });
            Console.WriteLine($"Average maximum speed: {averageMaxSpeed:F2} km/h");
            // Ən bahalı yanacaq xərci olan nəqliyyat
            double maxCost = double.MinValue;
            Vehicle mostExpensive = null;
            foreach (var v in vehicles)
            {
                double cost = 0;
                if (v is Car cc) cost = cc.CalculateFuelCost(500);
                else if (v is Motorcycle mm) cost = mm.CalculateFuelCost(300);
                else if (v is Truck tt) cost = tt.CalculateFuelCost(800);

                if (cost > maxCost)
                {
                    maxCost = cost;
                    mostExpensive = v;
                }
            }
            if (mostExpensive != null)
            {
                Console.WriteLine($"Vehicle with highest fuel cost: {mostExpensive.Brand} {mostExpensive.Model} with cost {maxCost:F2} AZN");
            }
            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();  } } }
