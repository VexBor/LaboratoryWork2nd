namespace LaboratoryWork2nd;

public class AnimalStruct
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Тварина: {Name}, Вік: {Age} р.");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} каже: Гав-гав!");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} каже: Мяу-мяу...");
        }
    }

    public class Parrot : Animal
    {
        public Parrot(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} каже: Полі хоче крекер! (імітує голоси)");
        }
    }
}