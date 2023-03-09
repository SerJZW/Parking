using Cars;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        CarClass[] array = new CarClass[0];
        Parking parking = new Parking();
        Menu menu = new Menu();
        int choice;
        while (true)
        {
            Console.WriteLine("Меню: \n 1 - Добавить машину \n 2 - Поиск по базе \n 3 - Показать все машины в базе \n 4 - Добавить на стоянку \n 5 - Информация о припаркованных авто\n 6 - Вывоз авто с парковки\n 7 - Выход из программы");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Menu.AddCar(ref array);
                    continue;
                case 2:
                    Menu.SearchCar(ref array);
                    continue;
                case 3:
                    Menu.PrintInfo(ref array);
                    continue;
                case 4:
                    Parking.ParkingCar(ref array);
                      continue;
                case 5:
                    Parking.PrintInfoParking(ref array);
                    continue;
                case 6:
                    Parking.ExportCar(ref array);
                    continue;
                case 7:
                    Console.WriteLine("Выход из программы");
                    break;
                default:
                    Console.WriteLine("Вы ввели неверную клавишу");
                    continue;
            }
            break;
        }
    }
}