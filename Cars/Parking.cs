using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Parking
    {
        public static void ParkingCar(ref CarClass[] array)
        {
            int i = 1;
            foreach (CarClass item in array)
            {
                Console.WriteLine("Машина номер " + i);
                Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n5. прибытие: {item.Arrive}\n");
                i++;
            }
            Console.WriteLine("Введите информацию о машине для парковки");
            string Parkcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            foreach (var item in array)
            {
                if (item.Mark == Parkcar || item.Model == Parkcar || item.Color == Parkcar || item.Number == Parkcar)
                {

                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n 5.время {item.Arrive}\n6. Парковка {item.OnPark} \nЭто та машина которую вы хотите припарковать?\n Y - да, любая другая клавиша - нет\n");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {

                        found = true;
                        item.OnPark = "Припаркована";
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }

            }
            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено\n");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено\n");
            }

        }
        public static void PrintInfoParking(ref CarClass[] array)
        {
            int i = 1;
            
            foreach (CarClass item in array)
            {
                if (item.OnPark == "Припаркована")
                {
                    Console.WriteLine("Машина номер " + i);
                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n5. прибытие: {item.Arrive}\n6. Парковка: {item.OnPark}\n");
                    i++;
                }
            }
        }
        public static void ExportCar(ref CarClass[] array)
        {
            int i = 1;
            foreach (CarClass item in array)
            {if (item.OnPark == "Припаркована")
                {
                    Console.WriteLine("Машина номер " + i);
                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n5. прибытие: {item.Arrive}\n6. Парковка: {item.OnPark}\n");
                    i++;
                }
            }
            Console.WriteLine("Введите информацию о машине для парковки");
            string Parkcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            foreach (var item in array)
            {
                if (item.Mark == Parkcar || item.Model == Parkcar || item.Color == Parkcar || item.Number == Parkcar || item.Number == Parkcar)
                {

                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n5.время {item.Arrive}\n6. Парковка: {item.OnPark} \nЭто та машина которую вы хотите Вывезти?\n Y - да, любая другая клавиша - нет\n");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {

                        found = true;
                        item.OnPark = "No parking";
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }

            }
            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено\n");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено\n");
            }

        }
    }
    
}
