namespace Opgaver
{
    public class Variabler
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Variabler!");

            Int1();
            Double1();
            Strings1();
            Bool1();
            StringInterpolation();
            Float1();
            Char1();
            Decimal1();
        }

        public static void Int1()
        {
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Lav en variabel af typen int og tildel den en værdi af ti!");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder! 
            int number = 10;
            Console.WriteLine(number);

        }

        public static void Double1()
        {
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("Lav en variabel af typen double og tildel den en værdi komma (decimal) værdi af 5 og en 1/4");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            double number = 5.25;
            Console.WriteLine(number);
        }

        public static void Strings1()
        {
            Console.WriteLine("Opgave 3: ");
            Console.WriteLine("Lav en variabel af typen string og tildel den en værdi - den skal indeholde teksten 'Hello, World' med et udråbstegn til sidst!");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            string greeting = "Hello, World!";
            Console.WriteLine(greeting);
        }

        public static void Bool1()
        {
            Console.WriteLine("Opgave 4: ");
            Console.WriteLine("Lav en variabel af typen bool og tildel den en sandhedsværdi (true/false).");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            bool bool1 = true;
            Console.WriteLine(bool1);
        }


        public static void StringInterpolation()
        {
            Console.WriteLine("Opgave 5: ");
            Console.WriteLine("Lav to string variabeler og udskriv dem ved brug af string interpolation.");
            Console.WriteLine("De skal være 'Hello, ' og 'World!'");
            // Lav opgaven herunder!
            string first = "Hello";
            string second = "World!";
            string full = first + second;
            Console.WriteLine(full);
        }

        public static void Float1()
        {
            Console.WriteLine("Opgave 6: ");
            Console.WriteLine("Lav en variabel af typen float og tildel den en værdi af 3 + 0.14");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            float pi = 3 + 0.14f;
            Console.WriteLine(pi);
            
        }

        public static void Char1()
        {
            Console.WriteLine("Opgave 7: ");
            Console.WriteLine("Lav en variabel af typen char og tildel den en værdi af det første bogstav i alfabetet (Det skal være stort!)");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            char characters = 'A';
            Console.WriteLine(characters);
        }

        public static void Decimal1()
        {
            Console.WriteLine("Opgave 8: ");
            Console.WriteLine("Lav en variabel af typen decimal og tildel den en værdi af 100 og en halv");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            decimal hundrede = 100.5m;
            Console.WriteLine(hundrede);
        }
    }
}
