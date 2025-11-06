using System;
using System.Collections.Generic;
using System.IO;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tələbələri yaradın
            List<Student> students = new List<Student>
            {
                new Student(1, "Ali", "Məmmədov", 20, 85.5),
                new Student(2, "Leyla", "Həsənova", 19, 92.0),
                new Student(3, "Vüqar", "Əliyev", 21, 78.5),
                new Student(4, "Nigar", "Əhmədova", 20, 88.0),
                new Student(5, "Rəşad", "Quliyev", 22, 95.5)
            };

            Console.WriteLine("=== Tələbələr ===");
            foreach (var s in students)
            {
                s.DisplayInfo();
            }

            // 2. FileManager və qovluq əməliyyatları
            FileManager fm = new FileManager();

            if (fm.CheckFolderExists())
                fm.DeleteFolder();

            fm.CreateFolder();
            Console.WriteLine($"Qovluq yaradıldı mı? {fm.CheckFolderExists()}");

            // 3. StreamWriter - bir-bir yazma
            foreach (var s in students)
            {
                fm.WriteStudentToFile(s);
            }

            // Toplu yazma
            fm.WriteAllStudentsToFile(students);

            // 4. StreamReader - oxuma
            List<Student> readStudents = fm.ReadStudentsFromFile();
            foreach (var s in readStudents)
            {
                s.DisplayInfo();
            }

            // 5. JSON serialize
            fm.SerializeToJson(students);

            // 6. JSON deserialize
            List<Student> jsonStudents = fm.DeserializeFromJson();
            foreach (var s in jsonStudents)
            {
                s.DisplayInfo();
            }

            // 7. Fayl əməliyyatları test
            Console.WriteLine("\n=== students.txt məzmunu ===");
            Console.WriteLine(File.ReadAllText(fm.TextFilePath));

            Console.WriteLine("\n=== students.json məzmunu ===");
            Console.WriteLine(File.ReadAllText(fm.JsonFilePath));

            // 8. Statistika
            int total = students.Count;
            double sum = 0, max = double.MinValue, min = double.MaxValue;
            int above90 = 0;

            foreach (var s in students)
            {
                sum += s.Grade;
                if (s.Grade > max) max = s.Grade;
                if (s.Grade < min) min = s.Grade;
                if (s.Grade >= 90) above90++;
            }

            double avg = sum / total;

            Console.WriteLine($"\nÜmumi tələbə sayı: {total}");
            Console.WriteLine($"Orta qiymət: {avg}");
            Console.WriteLine($"Ən yüksək qiymət: {max}");
            Console.WriteLine($"Ən aşağı qiymət: {min}");
            Console.WriteLine($"90+ qiymətli tələbə sayı: {above90}");

            FileInfo txtInfo = new FileInfo(fm.TextFilePath);
            FileInfo jsonInfo = new FileInfo(fm.JsonFilePath);
            Console.WriteLine($"students.txt ölçüsü: {txtInfo.Length} bytes");
            Console.WriteLine($"students.json ölçüsü: {jsonInfo.Length} bytes");
        }
    }
}
