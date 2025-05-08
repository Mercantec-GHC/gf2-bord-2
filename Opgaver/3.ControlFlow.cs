using System;
using System.ComponentModel.Design;
using System.Net.Mime;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(@"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!");
            If1();
            If2();
            Switch1();
            Ternary1();
            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er højere eller lavere end 18");
            // Lav opgaven herunder!
            Console.WriteLine("enter your age");
            string value = Console.ReadLine();
            float number = float.Parse(value);
            if (number < 18)
            {
                Console.WriteLine("your too young");
            }
            else
            {
                Console.WriteLine("your legal");
            }
        }
        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("enter a number");
            string value = Console.ReadLine();
            double number = double.Parse(value);
            if (number % 2 == 0)
            {
                Console.WriteLine("tal er lige");
            }
            else
            {
                Console.WriteLine("tal er ulige");
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("enter a number");
            string value = Console.ReadLine();
            float number = float.Parse(value);
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("dit tal er lige");
                    break;
                case 1:
                    Console.WriteLine("dit tal er ulige");
                    break;
                default:
                    Console.WriteLine("ugyldigt tal");
                    break;
            }

        }
        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("skriv et tal");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number));
                string result = (number % 2 == 0) ? "lige tal" : "ulige tal";
            Console.WriteLine(result);
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar).");
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine("Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik.");
            Console.WriteLine("Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene.");
            // Lav opgaven herunder!
            int point = 0;
            Console.WriteLine("hvad er 2x + 16 = 24");
            string svar1 = Console.ReadLine();
            if (int.TryParse(svar1, out int number1))
            {
                if (number1 == 4)
                {
                    Console.WriteLine("Rigtig!");
                    point += 1;
                }
                else
                {
                    Console.WriteLine("fuck du er dårlig");
                }
            }


            Console.WriteLine("hvad er 55 * 45");
            string svar2 = Console.ReadLine();
            if (int.TryParse(svar2, out int number2))
            {
                if (number2 == 2475)
                {
                    Console.WriteLine("Rigtig!");
                    point += 1;
                }
                else
                {
                    Console.WriteLine("fuck du er dårlig");
                }
            }


            Console.WriteLine("hvad er 69 * 2");
            string svar3 = Console.ReadLine();
            if (int.TryParse(svar3, out int number3))
            {
                if (number3 == 138)
                {
                    Console.WriteLine("Rigtig!");
                    point += 1;
                }
                else
                {
                    Console.WriteLine("fuck du er dårlig");
                }
            }
            Console.WriteLine($"Du har fået {point} ud af 3 spørgsmål rigtig");
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3).");
            Console.WriteLine(@"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv.");
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(@"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud.");
            // Lav opgaven herunder!
            List<int> karakterer = new List<int>();
            string input;

            Console.WriteLine("Skriv dine karakterer én ad gangen. Skriv 'done' når du er færdig.");

            while (true)
            {
                Console.WriteLine("skriv din karakter ind: ");
                input = Console.ReadLine();

                if (input.ToLower() == "done")
                    break;

                switch (input)
                {
                    case "12":
                        Console.WriteLine("Du har fået en kupon til en gratis sutter");
                        karakterer.Add(12);
                        break;
                    case "10":
                        Console.WriteLine("ik nok til at få bitches men godt klaret");
                        karakterer.Add(10);
                        break;
                    case "7":
                        Console.WriteLine("the middle man");
                        karakterer.Add(7);
                        break;
                    case "4":
                        Console.WriteLine("du klarede det sikkert bedre end du trode du ville");
                        karakterer.Add(4);
                        break;
                    case "02":
                        Console.WriteLine("du bestod det er alt der betyder noget");
                        karakterer.Add(2);
                        break;
                    case "00":
                        Console.WriteLine("dude cmon wtf du prøvede du overhovedet???");
                        karakterer.Add(0);
                        break;
                    case "-3":
                        Console.WriteLine("du var sikkert ikke engang til prøven");
                        karakterer.Add(-3);
                        break;
                    default:
                        Console.WriteLine("ugyldigt input");
                        break;
                }
            }

            if (karakterer.Count > 0)
            {
                double gennemsnit = karakterer.Average();
                Console.WriteLine($"\ndu intastede {karakterer.Count} karakterer dit gennemsnit er: {gennemsnit:F2}");
            }
            else
            {
                Console.WriteLine("ugyldigt input");
            }
        }
    }
}