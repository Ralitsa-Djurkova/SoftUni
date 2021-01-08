using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)


        {
            //1. read lenght, width, side wardrobe (m)
            //2. area of hall = (lenght * 100) * ( width * 100)->cm
            //3. area of wardrobe  = side wardrobe * side wardrobe
            //4. area bench = area of hall /10
            //5.free space = area of hall - area wardrobe - area bench
            //6. dancer = free space / 7040
            //7. print dancer-> Math. Floor

            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double areaHall = (lenght * 100) * (widht * 100);
            double areaWardrobe = (wardrobeSide * 100) * (wardrobeSide * 100);
            double areaBench = areaHall / 10;
            double freeSpace = areaHall - areaWardrobe - areaBench;
            double dancer = freeSpace / 7040;

            Console.WriteLine(Math.Floor(dancer));





        }
}
}
