using System;
using Task1_16._08._2022.Models;

namespace Task1_16._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            do
            {
                Console.WriteLine("1.Square");
                Console.WriteLine("2.Rectangular");
                Console.WriteLine("0.Exit");
                value = Convert.ToInt32(Console.ReadLine());
                
                if (value == 1)
                {
                    Console.Write("Enter the Side of the Square: ");
                    float Side = Convert.ToSingle(Console.ReadLine());
                    Square square = new Square(Side);
                    Console.WriteLine($"Area of the Square: {square.CalcArea()}\n");
                }
                else if (value == 2)
                {
                    Console.Write($"Enter the Width of the Rectangule: ");
                    float Width = Convert.ToSingle(Console.ReadLine());
                    Console.Write($"Enter the Length of the Rectangule: ");
                    float Length = Convert.ToSingle(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(Width, Length);
                    Console.WriteLine($"Area of the Rectangule: {rectangular.CalcArea()}\n");
                }
            }
            while (value != 0);
                    
           
        }
    }
}
