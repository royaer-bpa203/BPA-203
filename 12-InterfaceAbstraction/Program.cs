using System;
namespace SimpleCalculator
{   // İnterfeys: ICalculation
    public interface ICalculation
    {  double Calculate(double a, double b, char operation);  }
    // Sinif: Calculation
    public class Calculation : ICalculation
    { public double Calculate(double a, double b, char operation)
        {      switch (operation)
            {
                case '+':   return a + b;
                case '-':   return a - b;
                case '*':   return a * b;
                case '/':
                    if (b == 0)
                        throw new DivideByZeroException("0‐a bolme mumkun deyil.");
                    return a / b;
                default:
                    throw new InvalidOperationException($"Namelum emeliyyat: {operation}");  } } }
    // Program sinfi
    class Program
    {       static void Main(string[] args)
        {   ICalculation calc = new Calculation();
            try
            {   Console.Write("Birinci ededi daxil edin: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci ededi daxil edin: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Emeliyyat novunu daxil edin (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());
                double result = calc.Calculate(a, b, op);
                Console.WriteLine($"Netice: {a} {op} {b} = {result}");  }
            catch (Exception ex)
            { Console.WriteLine($"Xeta bas verdi: {ex.Message}");   }
            Console.WriteLine("Proqramdan cıxmaq üçün Enter duymesini basın...");
            Console.ReadLine();    } } }