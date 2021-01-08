using System;

namespace ConcatenateTextNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // read  firstname
            // read last name
            //read age
            //read town

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
