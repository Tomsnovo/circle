using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int enter;
            double pi = 3.14;
            double circuit;
            double content;
            double input;

            Console.Clear();
            Console.SetCursorPosition(5,1);
            Console.WriteLine("Circle (cm)");
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter 1 for radius");
            Console.WriteLine("Enter 2 for diameter");
            enter = int.Parse(Console.ReadLine());

            if (enter == 1)
            {
                Console.Write("Enter radius (r) ");

            }
            else if (enter == 2)
            {
                Console.Write("Enter diameter (d) ");
            }
            else if (enter <= 0 || enter >= 3)
            {
                Console.WriteLine("Enter valid numbers");
            }
            input = double.Parse(Console.ReadLine());
            input = Math.Round(input, 1);
            if (enter == 2)
            {
                input = input / 2;
            }

            circuit = 2 * pi * input;
            circuit = Math.Round(circuit, 1);

            content = pi * input * input;
            content = Math.Round(content, 1);

            Console.WriteLine($"Circuit is {circuit} cm ");
            Console.WriteLine($"Content is {content} cm ");

        }
    }
}
