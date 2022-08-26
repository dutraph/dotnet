using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello, World!");

            bool complete = false;
            char genre = 'F';
            sbyte s = 10;
            byte b = 126; //Não aceita numero negativo
            int i = 2147483647;
            long l = 2147483648L;
            float f = 4.5f;
            double d = 4.5;
            string nome = "Paulo"; //Imutavel
            object nome2 = "Paulo Dutra";
            nome2 = "Paulo Silva";
            nome = "Joao";


            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(complete);
            Console.WriteLine(genre);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(nome);
            Console.WriteLine(nome2);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine("------------------------------");

            char gn = 'M';
            int age = 32;
            double balance = 10.32443245;
            string name = "Paulo";

            Console.WriteLine(gn);
            Console.WriteLine(age);
            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine(name);

            Console.WriteLine("{0} is {1} years old, and have AU${2:F2}.", name, age, balance); // Placeholders

            Console.WriteLine($"{name} is {age} years old, and have AU${balance:F2}."); // Interpolation

            Console.WriteLine(name + " is " + age + " years old, and have AU$" + balance.ToString("F2")+ "."); // Concatenation

        }
    }
}