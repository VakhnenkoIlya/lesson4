using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new();
            building1.SetHeight(10);
            building1.SetFloorCount(4);
            building1.SetApartamentCount(16);
            building1.SetEntranceCount(2);
            Console.WriteLine($"Номер дома {building1.GetNumber()}\n" +
                $"Высота дома { building1.GetHeight()} m\n" +
                $"Количество этажей {building1.GetFloorCount()}\n" +
                $"Количество квартир {building1.GetApartamentCount()}\n" +
                $"Количество подъездов {building1.GetEntanceCount()}\n" +
                $"Высота одного этажа {building1.CalculationOfFloorHeight(10, 4)} m\n" +
                $"Квартир в подъезде {building1.CalculationApartamentInEntrance(16, 2)}\n" +
                $"Квартир на этаже {building1.CalculationApartamentInFloor(4, building1.CalculationApartamentInEntrance(16, 2))}");
           
        }
    }

