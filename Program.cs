using System;
namespace LaboratoryWork2nd;

public class BankTerminal
{
    public event <int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Знято: {amount}");
        OnMoneyWithdraw?.Invoke(amount);
    }
}

public static class Program
{
    static void Main(string[] args)
    {
        var terminal = new BankTerminal();
        terminal.OnMoneyWithdraw += (a) => Console.WriteLine($"SMS: {a} грн");

        terminal.OnMoneyWithdraw = null;
        terminal.OnMoneyWithdraw.Invoke(100500); 
    }
}