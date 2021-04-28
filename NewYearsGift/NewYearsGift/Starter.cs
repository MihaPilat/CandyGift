using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class Starter
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сейчас мы создадим новогодний подарок для сладкоешки Машки");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Он будет состоять из конфет.\nВведи 1, если хочешь добавить только обычные шоколадные, 2 все типы шоколадных и 3 все типы конфет: ");
            int giftOption = Convert.ToInt32(Console.ReadLine());
            int sizeGift = new Random().Next(5, 20);
            Console.WriteLine($"Рамдомный размер нашего подарка: {sizeGift}");
            Gift gift = null;
            switch (giftOption)
            {
                case 1:
                    ChocolateGift chocolateGift = new ChocolateGift();
                    gift = chocolateGift.Create(sizeGift);
                    break;
                case 2:
                    AllChocolateGift allChocolateGift = new AllChocolateGift();
                    gift = allChocolateGift.Create(sizeGift);
                    break;
                case 3:
                    AllCandyGift allCandyGift = new AllCandyGift();
                    gift = allCandyGift.Create(sizeGift);
                    break;
            }

            DeterminingWeight determiningWeight = new DeterminingWeight();
            int weigthGift = determiningWeight.DeterminingWeightGift(gift);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Вес нашего подарка: {weigthGift}");
            SortingGift sortingGift = new SortingGift();
            gift = sortingGift.Sorting(gift);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Отсортировали подарок по весу...");
            PrintGift printGift = new PrintGift();
            printGift.DisplayGift(gift);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("А узнаем индекс конфеты в подарке. Введи размер конфеты, которую хочешь найти: ");
            Console.ForegroundColor = ConsoleColor.White;
            int weightCandy = Convert.ToInt32(Console.ReadLine());
            SearchCandy searchCandy = new SearchCandy();
            int indexCandy = searchCandy.Search(gift, weightCandy);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Она находится под {indexCandy} индексом.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Конец");
        }
    }
}
