using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace _06.Cake
    {
        class Program
        {
            static void Main(string[] args)
            {

                int leghtcake = int.Parse(Console.ReadLine());
                int WeightCake = int.Parse(Console.ReadLine());
                int razmerCake = leghtcake * WeightCake;
                string command = "";



                while (command != "Stop")
                {

                    int countPicescake = int.Parse(Console.ReadLine());
                    razmerCake = razmerCake - countPicescake;

                    if (razmerCake >= 1)
                    {
                        Console.WriteLine($"{razmerCake} pieces are left.");

                    }
                    else if (razmerCake < 1)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(razmerCake)} pieces more.");


                    }

                }


            }
        }
    }

}
    }
}
