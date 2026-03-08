using System;
class Transaction
{
    public int TransactionId;
    public string ProductName;
    public double Amount;
    public DateTime DateTime;
    // Constructor
    public Transaction(int id, string name, double amount, DateTime date)
    {
        TransactionId = id;
        ProductName = name;
        Amount = amount;
        DateTime = date;
    }
    // Copy Constructor
    public Transaction(Transaction t)
    {
        TransactionId = t.TransactionId;
        ProductName = t.ProductName;
        Amount = t.Amount;
        DateTime = t.DateTime;
    }
}
class Program
{
    static void Main()
    {
        Transaction t1 = new Transaction(1, "Laptop", 80000, DateTime.Now);
        Transaction t2 = new Transaction(t1);
        Console.WriteLine("Transaction 1 Product: " + t1.ProductName);
        Console.WriteLine("Transaction 2 Product: " + t2.ProductName);
    }
}