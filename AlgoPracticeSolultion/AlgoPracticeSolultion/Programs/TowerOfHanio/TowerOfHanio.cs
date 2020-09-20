using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoiPractice
{
    class Program
    {
        static void TowerOfHanio(int numbers, char source, char destination, char auxilary)
        {
            if (numbers > 0)
            {
                TowerOfHanio(numbers - 1, source, auxilary, destination);
                Console.WriteLine($"Moves disk from {source} to {destination}");
                TowerOfHanio(numbers - 1, auxilary, destination, source);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers of disks");
            var diskNumbers = int.Parse(Console.ReadLine());
            char source = 'S', destination = 'D', auxilary = 'A';
            TowerOfHanio(diskNumbers, source, destination, auxilary);
            Console.ReadLine();

        }
    }
}
