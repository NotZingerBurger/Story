// CTRL + * = Comments
// CTRL + ALT + UP ARROW/ DOWN ARROW = Copy and paste
// CTRL + ARROW/ DOWN ARROW = Move up or down


Console.WriteLine("You're somewhere lost in the forest and you found a house. Do you enter? [Yes or No]");

string choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "yes")
{
    Console.WriteLine("You knocked on the door three times but no one answered.");
    Console.WriteLine("You decided to break in to the house but when you broke through there was already someone waiting for you.");
    Console.WriteLine("It was a wolf and he ate you up so u died!");
}
else if (choice == "no")
{
    Console.WriteLine("You kept going forward and found a path with two ways. Do you go [left or right]?");

    string choice2 = Console.ReadLine();
    choice2 = choice2.ToLower();

    if (choice2 == "left")
    {
        Console.WriteLine("You went with the left path and found your way out of the forest and escaped!");
        Console.WriteLine("Congrats, You Won!");
    }
    else if (choice2 == "right")
    {
        Console.WriteLine("You went with the right path and went deeper in the forest.");
        Console.WriteLine("On your way a wolf appeared and it decided to eat you, so u basically died...:]");
    }
    else
    {
        Console.WriteLine("=(");
    }
}
else if (choice == "maybe")
{
    Console.WriteLine("Sorry, but \"maybe\" is not a real answer. You died to the gamerule!");
}
else
{
    Console.WriteLine("=(");
}

Console.ReadLine();