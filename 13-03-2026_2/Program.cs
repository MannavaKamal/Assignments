namespace _13_03_2026_2;

internal class Program
{
    static void Main(string[] args)
    {
        Account acc = null;
        int choice;

        do
        {
            Console.WriteLine("\n1. Create an Account");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Initial Balance: ");
                    double balance = double.Parse(Console.ReadLine());

                    Console.Write("Enter Account Type (Savings/Current): ");
                    string type = Console.ReadLine();

                    acc = new Account(name, balance, type);

                    Console.WriteLine("Account Created Successfully.");
                    Console.WriteLine("Account Number: " + acc.AccountNumber);
                    break;

                case 2:
                    if (acc != null)
                        acc.ShowBalance();
                    else
                        Console.WriteLine("Please create an account first.");
                    break;

                case 3:
                    if (acc != null)
                    {
                        Console.Write("Enter amount to deposit: ");
                        double deposit = double.Parse(Console.ReadLine());
                        acc.Deposit(deposit);
                    }
                    else
                        Console.WriteLine("Create account first.");
                    break;

                case 4:
                    if (acc != null)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        acc.Withdraw(withdraw);
                    }
                    else
                        Console.WriteLine("Create account first.");
                    break;

                case 5:
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
