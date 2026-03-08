using System;
class ATM
{
    double balance;
    string[] history = new string[10];
    int index = 0;
    public ATM(double b)
    {
        balance = b;
    }
    public void Deposit(double amount)
    {
        balance = balance + amount;
        history[index++] = "Deposited: " + amount;
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            history[index++] = "Withdraw: " + amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
    public void ShowHistory()
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(history[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        ATM atm = new ATM(5000);
        atm.Deposit(2000);
        atm.Withdraw(1000);
        atm.CheckBalance();
        atm.ShowHistory();
    }
}