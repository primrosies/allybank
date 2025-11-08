// Current balance

double balance = 1000.00;

Console.WriteLine("Welcome to Allybank!");

while (true)
{
    Console.WriteLine("Enter the preferred option:");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");

    string option = Console.ReadLine() ?? "";
    if (option == "4")
    {
        Console.WriteLine("Bye bye, see you soon!");
        return;
    }

    switch (option)
    {
        case "1":
            Console.WriteLine($"Your current balance is {balance:F2}");
            break;

        case "2":
            Console.WriteLine("How much do you wish to deposit: ");
            double deposit = double.Parse(Console.ReadLine() ?? "");
            balance += deposit;
            Console.WriteLine($"Deposit successful! Your current balance is {balance:F2}\n");
            break;

        case "3":
            Console.WriteLine("How much do you wish to withdraw: ");
            double withdraw = double.Parse(Console.ReadLine() ?? "");
            if (balance < withdraw)
            {
                Console.WriteLine("Insufficient balance!\n");
            }
            else
            {
                balance -= withdraw;
                Console.WriteLine($"Withdraw successful! Your current balance: {balance:F2}\n");
            }
            break;

        default:
            Console.WriteLine("Invalid option!\n");
            return;
    }
}



