using System;
namespace LaboratoryWork2nd;

public static class Program
{
    static void Main(string[] args)
    {
        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
            var t = i;
            actions.Add(() => Console.WriteLine(t));
        }

        foreach (var action in actions)
        {
            action();
        }
    }
}