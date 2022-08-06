using System;

namespace madLibConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter Colour: ");
            color = Console.ReadLine();

            Console.Write("Enter Plural Noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter Celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Roses are " + color);

            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);


            Console.ReadLine();
        }
    }
}
