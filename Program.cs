using System;
using LaboratoryWork2nd;
namespace LaboratoryWork2nd;

public static class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<AnimalStruct.Animal> zoo = new List<AnimalStruct.Animal>
        {
            new AnimalStruct.Dog("Рекс", 5),
            new AnimalStruct.Cat("Мурчик", 3),
            new AnimalStruct.Parrot("Кеша", 2)
        };

        Console.WriteLine("=== Демонстрація голосів тварин ===");
        foreach (var animal in zoo)
        {
            animal.DisplayInfo();
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}