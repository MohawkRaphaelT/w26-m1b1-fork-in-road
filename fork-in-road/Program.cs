// Steps 1 & 2
Console.WriteLine("You reach a fork in the road.");
Console.WriteLine("Say LEFT to go towards a town.");
Console.WriteLine("Say RIGHT to go towards a mountain.");

// Step 3: get user response, remember it in string variable
string userInput;                // declare
userInput = Console.ReadLine()!; // initialize

// Step 4: check player's response for LEFT or RIGHT
if (userInput == "LEFT")
{
    Console.WriteLine("You arrive at a town called...");
}
else if (userInput == "RIGHT")
{
    Console.WriteLine("You arrive at a mountain called...");
}
else
{
    Console.WriteLine("The only valid options to type are LEFT and RIGHT");
}

Console.WriteLine("THE END");
