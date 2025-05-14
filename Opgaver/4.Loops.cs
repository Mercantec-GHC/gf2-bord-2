using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
            Loop6();
            Loop7();
            Loop8();
            Loop9();
            Loop10();
            BankeBøf();
            MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("i = " + i);
            }
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            for (int i = 2; i <= 20; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine("i = " + i);
                }
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine($"totalt sum of numbers = {sum}");
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            Console.WriteLine("Skriv dit navn");
            string name = Console.ReadLine();
            Console.WriteLine("Hvor mange gange skal det skrives?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            while (number > 0)
            {
                Console.WriteLine($"{name}");
                number--;
            }
        }
        
        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast tal");
            string input = Console.ReadLine() ;
            Console.Clear();
            if (int.TryParse(input,out int number))
                while (number >= 1)
                {
                    Console.WriteLine($"{number}");
                    number--;
                }
        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn");
            string name = Console.ReadLine();
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            char targetletter = 'a';
            foreach (char letter in text)
            {
                if (letter == targetletter)
                {
                    Console.WriteLine(letter);
                }
            }
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 50; i++)
                if (i % 2 == 1)
                {
                    Console.WriteLine("i = " + i);
                }

        }

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
            List<int> list = new List<int>();
            string input;

            Console.WriteLine("skriv 5 tal en ad gangen");
            
            while (list.Count < 5)
            {
            input = Console.ReadLine();
            if (int.TryParse(input, out int number))
                list.Add(number);
            }
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            Console.WriteLine($"summen af talne er {sum}");

        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            Console.WriteLine("gæt tallet");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
                while (number != 7)
                {
                    Console.WriteLine("forkert prøv igen");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out number)) ;
                }
            Console.WriteLine("Rigtig!!");
        }

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 30; i++)
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BankeBøf");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Banke");
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("Bøf");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
            Console.WriteLine("skriv dit første tal");
            string num1 = Console.ReadLine();
            if (decimal.TryParse(num1, out decimal num3))
                        Console.WriteLine("skriv dit andet tal");
            string num2 = Console.ReadLine();
            if (decimal.TryParse(num2, out decimal num4))
                    Console.WriteLine("hvilken regne art skal du bruge?");
            string regneart = Console.ReadLine();
            switch (regneart)
            {
                    case "+":
                    decimal resultat1 = num3 + num4;
                    Console.WriteLine($"{resultat1}");
                    break;
                    case "-":
                    decimal resultat2 = num3 - num4;
                    Console.WriteLine($"{resultat2}");
                    break;
                    case "*":
                    decimal resultat3 = num3 * num4;
                    Console.WriteLine($"{resultat3}");
                    break;
                    case "/":
                    decimal resultat4 = num3 / num4;
                    Console.WriteLine($"{resultat4}");
                    break;
                    default:
                    Console.WriteLine("ugyldigt input");
                    break;
            }
        }
    }
}