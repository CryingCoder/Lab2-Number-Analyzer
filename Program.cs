bool loopy = true;

while (loopy)
{
    Console.WriteLine("Greetings Traveler! What do you call yourself?");
    string name = Console.ReadLine();
    Console.WriteLine("Wonderful " + name +"!" + "\n" + "Pick a number between 1 and 100.");
    
    int eValue = int.Parse(Console.ReadLine());
    if (eValue > 1 || eValue < 100)
    {
        Console.WriteLine(name + ", the number you entered is not between 1 and 100. Please pick another number!");
        continue;
    }

    if (eValue < 60 && eValue % 2 == 1)
    {
        Console.WriteLine(eValue + " is: " + " Odd and less than 60");
    }
    else if (eValue >= 2 && eValue <= 24 && eValue % 2 == 0)
    {
        Console.WriteLine(eValue + " is: " + " Even and less than 25");
    }
    else if (eValue >= 26 && eValue <= 60 && eValue % 2 == 0)
    {
        Console.WriteLine(eValue + " is: " + " Even and between 26 and 60 inclusive");
    }
    else if (eValue > 60 & eValue % 2 == 0)
    {
        Console.WriteLine(eValue + " is: " + " Even and greater than 60");
    }
    else
    {
        Console.WriteLine(eValue + " is:" + " Odd and greater than 60");
    }

    bool rerun = true;
    while (rerun)
    {
        Console.WriteLine("Do you want to try another number, " + name + "?");
        string input = Console.ReadLine().ToLower();

        if (input == "y")
        {
            loopy = true;
            rerun = false;
        }
        else if (input == "n")
        {
            loopy = false;
            rerun = false;
        }
        else
        {
            Console.WriteLine("I'm sorry, please enter 'y' or 'n' ");
            rerun = true;

        }
    }
}