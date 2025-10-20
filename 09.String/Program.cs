////Task 1.Verilmis string-de sait herflewrin tapilmasi
//using System;

//class Program
//{
//    static void Main()
//    {
//        string input = "I am Backend DEVELOPER I LEARN C#";
//        string vowels = "aeiouAEIOU";

//        Console.WriteLine("Sait herfler:");
//        foreach (char c in input)
//        {
//            if (vowels.Contains(c))
//            {
//                Console.Write(c + " ");
//            }
//        }
//    }
//}


////Task 2.Verilmish string-de sozlerin bosluga gore sayi
//using System;

//class Program
//{
//    static void Main()
//    {
//        string input = "I am Backend DEVELOPER I LEARN C#";
//        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        Console.WriteLine("Sozlerin sayı: " + words.Length);
//    }
//}



////Task 3.Verilmiş stringin-in ən uzun sözünü ekrana çıxaran proqram yazın
//using System;

//class Program
//{
//    static void Main()
//    {
//        string input = "I am Backend DEVELOPER I LEARN C#";
//        string[] words = input.Split(' ');
//        string longestWord = "";
//        foreach (string word in words)
//        {
//            if (word.Length > longestWord.Length)
//            {
//                longestWord = word;
//            }
//        }
//        Console.WriteLine("En uzun soz: " + longestWord);
//    }
//}


////Task 4.Verilmiş string-in bütün hərfləri böyük olan sözün özünü və indeksini çapa çıxaran proqram yazın.
//using System;
//class Program
//{
//    static void Main()
//    {
//        string input = "I am Backend DEVELOPER I LEARN C#";
//        string[] words = input.Split(' ');
//        Console.WriteLine("Tam boyuk herflerden ibaret sozler ve indeksleri:");
//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i] == words[i].ToUpper() && words[i].Length > 0 && Char.IsLetter(words[i][0]))
//            {
//                Console.WriteLine($"İndeks: {i}, Soz: {words[i]}");
//            } } } }



////Task 5. Verilmiş string-in 2-dən artıq böyük hərfi olan elementlərini çapa çıxaran proqram yazın
//using System;
//class Program
//{
//    static void Main()
//    {
//        string input = "I am Backend DEVELOPER I LEARN C#";
//        string[] words = input.Split(' ');
//        Console.WriteLine("İki ve daha çox boyuk herfi olan sozler:");
//        foreach (string word in words)
//        {
//            int upperCount = 0;
//            foreach (char c in word)
//            {
//                if (char.IsUpper(c))
//                    upperCount++;
//            }
//            if (upperCount >= 2)
//            {
//                Console.WriteLine(word);  } } } }