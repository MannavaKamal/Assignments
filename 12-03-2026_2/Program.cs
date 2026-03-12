namespace _12_03_2026_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            BankAccount acc1 = new BankAccount("Alice", rand.Next(1000, 5000));
            BankAccount acc2 = new BankAccount("Bob", rand.Next(1000, 5000));
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Round No {i + 1}");

                double amount1 = rand.Next(100, 500);
                double amount2 = rand.Next(100, 500);

                if (rand.Next(2) == 0)
                    acc1.Deposit(amount1);
                else
                    acc1.Withdraw(amount1);

                if (rand.Next(2) == 0)
                    acc2.Deposit(amount2);
                else
                    acc2.Withdraw(amount2);
            }

            Console.WriteLine($"finial balance of Account1 {acc1.Balance}");
            Console.WriteLine($"finial balance of Account2 {acc2.Balance}");

            if (acc1.Balance > acc2.Balance)
                Console.WriteLine("Account Holder1 is the Winner");
            else if (acc2.Balance > acc1.Balance)
                Console.WriteLine("Account Holder2 is the Winner");
            else
                Console.WriteLine("The Match is Draw!");
        }
    }
}
