using System;

namespace _04.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //крайна цена = броя на цветята * единична цена
            double singlePrice = 0;

            switch (flowerType)
            {
                case"Roses":
                    singlePrice = 5;
                    break;
                case "Dahlias":
                    singlePrice = 3.80;
                    break;
                case "Tulips":
                    singlePrice = 2.80;
                    break;
                    case "Narcissus":
                    singlePrice = 3;
                    break;
                case "Gladiolus":
                    singlePrice = 2.50;
                    break;
            } 

            double totalPrice = flowerCount * singlePrice;
            //•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
	        // Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
	         //Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
             // Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
	        // Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20

            if(flowerCount > 80 && flowerType =="Roses")
            {
                totalPrice = totalPrice * 0.9;//totalPrice -0.10 * totalPrice
            }
            else if(flowerCount > 90 && flowerType =="Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if(flowerCount > 80 && flowerType =="Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if(flowerCount < 120 && flowerType == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if(flowerCount < 80 && flowerType =="Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }

            if(budget >= totalPrice)
                
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }

        }
    }
}
