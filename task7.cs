using System;
class MUser
{
    public string username;
    public string password;
    public string role;
}
class Program
{
    static void Main()
    {
        MUser[] users = new MUser[10];
        int count = 0;
        users[count] = new MUser();
        users[count].username = "admin";
        users[count].password = "123";
        users[count].role = "Admin";
        count++;
        string uname, pass;
        Console.Write("Enter Username: ");
        uname = Console.ReadLine();
        Console.Write("Enter Password: ");
        pass = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (users[i].username == uname && users[i].password == pass)
            {
                Console.WriteLine("Login Successful");
                Console.WriteLine("Role: " + users[i].role);
                found = true;
            }
        }
        if (found == false)
        {
            Console.WriteLine("Invalid User");
        }
    }
}