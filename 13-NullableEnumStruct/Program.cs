using System;
namespace SimpleCafeOrderSystem
{
    // İçki növləri
    enum DrinkType
    {
        Coffee = 0,
        Tea = 1,
        Juice = 2,
        Water = 3
    }
    // Ölçülər
    enum DrinkSize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
    // Sifariş statusu
    enum OrderStatus
    {
        New = 0,
        Preparing = 1,
        Ready = 2,
        Delivered = 3
    }
    // İçki sifarişi sinfi
    class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();
        }
        // Qiyməti hesablayan metod
        private decimal CalculatePrice()
        {
            switch (Drink)
            {
                case DrinkType.Coffee:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 3m;
                        case DrinkSize.Medium: return 4m;
                        case DrinkSize.Large: return 5m;
                    }
                    break;

                case DrinkType.Tea:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 2m;
                        case DrinkSize.Medium: return 3m;
                        case DrinkSize.Large: return 4m;
                    }
                    break;

                case DrinkType.Juice:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 4m;
                        case DrinkSize.Medium: return 5m;
                        case DrinkSize.Large: return 6m;
                    }
                    break;

                case DrinkType.Water:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 1m;
                        case DrinkSize.Medium: return 1.5m;
                        case DrinkSize.Large: return 2m;
                    }
                    break;
            }
            return 0m;
        }

        // Statusu yeniləyən metod
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifaris #{OrderNumber} statusu: {newStatus}");
        }

        // Sifariş məlumatlarını göstərən metod
        public void DisplayOrder()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Sifaris nomresi: {OrderNumber}");
            Console.WriteLine($"Musteri adı: {CustomerName}");
            Console.WriteLine($"İcki: {Drink}");
            Console.WriteLine($"Olcu: {Size}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Qiymet: {Price} AZN");
            Console.WriteLine("----------------------------\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. SİFARİŞLƏRİN YARADILMASI ---

            DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);

            DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);

            DrinkOrder order3 = new DrinkOrder(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
            order3.DisplayOrder();

            // --- 2. ENUM METODLARI ---

            Console.WriteLine("Butun DrinkType deyerleri:");
            foreach (var val in Enum.GetValues(typeof(DrinkType)))
                Console.WriteLine(val);
            Console.WriteLine();

            Console.WriteLine("Butun DrinkSize deyerleri:");
            foreach (var val in Enum.GetValues(typeof(DrinkSize)))
                Console.WriteLine(val);
            Console.WriteLine();

            Console.WriteLine("Butun OrderStatus deyerleri:");
            foreach (var val in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(val);
            Console.WriteLine();

            // ToString() nümunələri
            Console.WriteLine("Enum ToString() numuneleri:");
            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(DrinkSize.Large.ToString());
            Console.WriteLine();

            // Parse() nümunələri
            Console.WriteLine("Enum Parse() numuneleri:");
            DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            Console.WriteLine($"Parsed DrinkType: {parsedDrink}");
            Console.WriteLine($"Parsed DrinkSize: {parsedSize}");
            Console.WriteLine();

            // --- 3. SADƏ STATİSTİKA ---
            Console.WriteLine("STATİSTİKA:");
            Console.WriteLine($"Umumi sifaris: 3");
            Console.WriteLine($"1-ci sifarisin qiymeti: {order1.Price} AZN");
            Console.WriteLine($"2-ci sifarisin qiymeti: {order2.Price} AZN");
            Console.WriteLine($"3-cu sifarisin qiymeti: {order3.Price} AZN");
            decimal total = order1.Price + order2.Price + order3.Price;
            Console.WriteLine($"Umumi mebleğ: {total} AZN");

            Console.WriteLine("\nProqram bitdi.");
        }
    }
}
