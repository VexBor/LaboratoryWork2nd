using System;
using System.Collections.Generic;

public interface IRefuelable
{
    void Refill();
}

public abstract class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    protected Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public abstract void Move();
}

public class Car : Vehicle, IRefuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move() => Console.WriteLine($"[Car] {Brand} їде по дорозі зі швидкістю {Speed} км/год.");
    public void Refill() => Console.WriteLine($"[Car] {Brand} заправлено бензином.");
}

public class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move() => Console.WriteLine($"[Bicycle] {Brand} рухається за допомогою педалей.");
}

public class Airplane : Vehicle, IRefuelable
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move() => Console.WriteLine($"[Airplane] {Brand} летить у небі на швидкості {Speed} км/год.");
    public void Refill() => Console.WriteLine($"[Airplane] {Brand} заправлено авіаційним паливом.");
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Tesla", 120),
            new Bicycle("Giant", 25),
            new Airplane("Boeing", 850),
            new Car("Porhce", 320)
        };

        foreach (var v in vehicles)
        {
            v.Move();
            if (v is IRefuelable refuelable)
            {
                refuelable.Refill();
            }
        }
    }
}