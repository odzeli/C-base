using System;

namespace Questionnaire
{
    class FirstHomeWorkClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1._______________________________________________________________________");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Enter your growth: ");
            string growth = Console.ReadLine();
            Console.Write("Enter your weight in kilograms: ");
            string weight = Console.ReadLine();
            Console.WriteLine($"First name: {firstName}, Surname: {surName}, Age: {age}, Growth: {growth}, Weight: {weight}");
            Console.WriteLine("2._______________________________________________________________________");
            bodyMassIndex(growth, weight);
            Console.WriteLine("3._______________________________________________________________________");
            distanceBetweenPoints();
            Console.WriteLine("4._______________________________________________________________________");
            Console.Write("Enter a: ");
            string a = Console.ReadLine();
            Console.Write("Enter b: ");
            string b = Console.ReadLine();
            Console.WriteLine($"Value of variables: a = {a}, b = {b} ");
            swap(a, b);
            Console.WriteLine("5.________________________________________________________________________");
            Console.SetCursorPosition(40, Console.CursorTop + 3);
            Console.WriteLine("Archil Odzeli, Saint-Petersburg");

            Console.ReadKey();
        }

        //2.
        static void bodyMassIndex(string growthString, string weightString)
        {
            if (!int.TryParse(growthString, out int growth) || !int.TryParse(weightString, out int weight))
            {
                Console.WriteLine($"В growth или в weight переменные вместо числа была введена строка");
                return;
            }
            double growthInMetres = growth / 100.00;
            double bmi = weight / (growthInMetres * growthInMetres);
            Console.WriteLine($"Body Mass Index: {bmi}");
        }

        //3.
        static void distanceBetweenPoints()
        {
            double distance = Math.Sqrt(Math.Pow(10 - 5, 2) + Math.Pow(10 - 5, 2));
            var formatValue = String.Format("{0:f2}", distance);
            Console.WriteLine($"Distance between points: {formatValue}");
        }

        //4.
        static void swap(string aString, string bString)
        {
            if (!int.TryParse(aString, out int a) || !int.TryParse(bString, out int b))
            {
                Console.WriteLine($"В a или в b переменные вместо числа была введена строка");
                return;
            }
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Variables was swaped: a = {a}, b = {b}");
        }
    }
}
