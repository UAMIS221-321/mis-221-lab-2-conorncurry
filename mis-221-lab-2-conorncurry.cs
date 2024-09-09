System.Console.WriteLine("welcome to your handy order calculator!");

    System.Console.WriteLine("Please Enter Total Sandwich Orders:");
    string totalSandwichInput = Console.ReadLine();
    int totalSandwiches = int.Parse(totalSandwichInput);

    System.Console.WriteLine("Now Please Enter Amount of Toppings");
    string totalToppingsInput = Console.ReadLine();
    int totalToppings = int.Parse(totalToppingsInput);

    double sandwhichTotal = totalSandwiches * 4.75;
    double toppingTotal = totalToppings * 0.55;
    double orderTotal = sandwhichTotal + toppingTotal * 0.10;

System.Console.WriteLine("The total of this order is $" + orderTotal);