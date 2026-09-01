// CTRL + * = Comments
// CTRL + ALT + UP ARROW/ DOWN ARROW = Copy and paste
// CTRL + ARROW/ DOWN ARROW = Move up or down


using System.Xml.Serialization;

Console.WriteLine("Your somewhere lost in the forest and you found a house. Do you enter? [Yes or No]");
// bool t = 6 > 4;
// Console.WriteLine(t);
string choice = Console.ReadLine();
string choice2 = Console.ReadLine();
choice = choice.ToLower();
choice2 = choice2.ToLower();

if (choice == "yes")
{
    Console.WriteLine("You knocked on the door three times but no one answered.");
    Console.WriteLine("You decided to break in to the house but when broke throught there was already someone waiting for you. It was the wolf and he ate you up so u died!");
}
else if (choice == "no")
{
    Console.WriteLine("You kept going foward and found a path with two ways. Do you go left or right?");
}

else if (choice == "maybe")
{
    Console.WriteLine("Sorry, but ¨maybe¨ is not a real answer, You died to the gamerule!");
}

else
{
    Console.WriteLine("=(");
}

if (choice2 == "left")
{
    Console.WriteLine("You went with the left path and found your way out of the forest and escaped!");
    Console.WriteLine("Congrats, You Won!");
}

else if (choice2 == "right")
{
    Console.WriteLine("You went with the ¨right¨ path and went deeper in the forest.");
    Console.WriteLine("On your way a wolf appeard and it decided to eat you, so u basicly died...:]");

}

else
{
    Console.WriteLine("=(");
}

Console.ReadLine();