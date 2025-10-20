////1.Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.
//using System; 
//namespace RiyaziEmellerProqrami
//{ class RiyaziEmeller
//    { public static int Topla(int a, int b)
//        { return a + b; }
//        public static int Cix(int a, int b)
//        { return a - b; }
//        public static int Vur(int a, int b)
//        { return a * b; }
//        public static double Bol(int a, int b)
//        {   if (b == 0)
//            {   Console.WriteLine("Xeta: Sıfıra bölmek olmaz!");
//                return double.NaN; // NaN = Not a Number
//            }
//            return (double)a / b;  } }
//    class Program
//    { static void Main(string[] args)
//        {
//            Console.Write("Birinci ededi daxil edin: ");
//            int eded1 = Convert.ToInt32(Console.ReadLine());
//            Console.Write("İkinci ededi daxil edin: ");
//            int eded2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("\n--- Neticeler ---");
//            Console.WriteLine("Toplama: " + RiyaziEmeller.Topla(eded1, eded2));
//            Console.WriteLine("Çıxma: " + RiyaziEmeller.Cix(eded1, eded2));
//            Console.WriteLine("Vurma: " + RiyaziEmeller.Vur(eded1, eded2));
//            Console.WriteLine("Bolme: " + RiyaziEmeller.Bol(eded1, eded2));
//            Console.WriteLine("\nProqram sona çatdı."); } } }





////2.Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)
//using System;
//namespace TekVeCutEdeler
//{ class Ededler
//    { public static void TekVeCut(int[] ededler)
//        { Console.WriteLine("Tek ededler:");
//            foreach (int eded in ededler)
//            { if (eded % 2 != 0)
//                { Console.Write(eded + " "); } }
//            Console.WriteLine("\nCut ededler:");
//            foreach (int eded in ededler)
//            { if (eded % 2 == 0)
//                { Console.Write(eded + " "); } } } }
//    class Program
//    { static void Main(string[] args)
//        { int[] ededler = { 14, 20, 35, 40, 57, 60, 100 };
//            Ededler.TekVeCut(ededler);
//            Console.WriteLine("\nProqram sona çatdı."); } } }




////3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]
//using System;
//namespace BolunenEdedler
//{ class Ededler
//    { public static int BolunenlerinCemi(int[] ededler)
//        { int cem = 0;
//            foreach (int eded in ededler)
//            { if (eded % 4 == 0 && eded % 5 == 0)
//                { cem += eded; } }
//            return cem; } }
//    class Program
//    { static void Main(string[] args)
//        { int[] ededler = { 14, 20, 35, 40, 57, 60, 100 };
//            int cem = Ededler.BolunenlerinCemi(ededler);
//            Console.WriteLine("Hem 4-e, hem de 5-e bolunen elementlerin cemi: " + cem);
//            Console.WriteLine("Proqram sona çatdı."); } } }




////4.Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).
//using System;
//namespace SimvolSayma
//{ class SimvolCounter
//    { public static int SimvolunSayi(string cumle, char simvol)
//        { int say = 0;
//            foreach (char c in cumle)
//            { if (c == simvol)
//                { say++; } }
//            return say; } }
//    class Program
//    { static void Main(string[] args)
//        { Console.Write("Cumleni daxil edin: ");
//            string cumle = Console.ReadLine();
//            Console.Write("Sayini tapmaq istediyiniz simvolu daxil edin: ");
//            char simvol = Console.ReadLine()[0];
//            int say = SimvolCounter.SimvolunSayi(cumle, simvol);
//            Console.WriteLine($"Cumlede '{simvol}' simvolunun sayi: " + say);
//            Console.WriteLine("Proqram sona çatdı."); } } }