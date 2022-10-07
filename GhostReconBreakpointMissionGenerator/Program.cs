// See https://aka.ms/new-console-template for more information
Random random = new Random();
String[] typeArray = { "EPISODE 1", "EPISODE 2", "EPISODE 3", "HARUHI ITO", "A LONG ROAD TO VICTORY", "MADS SCHULZ", "STAYING SAFE", "OPERATION AMBER SKY", "RESISTANCE",
                       "OPERATION MOTHERLAND" };
String[] EPISODE1Array = { "OPERATION GREENSTONE", "LTC. COLE D. WALKER", "JACE SKELL", "MAURICE FOX", "AUROA ARCHIPELAGO", "FLYCATCHER", "ROSEBUD", "PAULA MADERA",
                           "CHRISTINA CROMWELL", "SILVERBACK", "CARL CHISUM", "AYANA PURI" };
Console.WriteLine("Hello, Ghost!");
Console.WriteLine("Welcome to Breakpoint Mission Generator created by Justin Zhao");
Console.WriteLine("Press 1 to randomly generator your mission.");
Console.WriteLine("Press 0 to exit");
String input = Console.ReadLine();
while(Convert.ToInt32(input) != 0)
{
    int type = random.Next(0, 9);
    Console.WriteLine(typeArray[type]);
    int EPISODE1 = random.Next(0, 11);
    if (type == 0)
    {
        Console.WriteLine(EPISODE1Array[EPISODE1]);
    }
    else if (type == 1)
    {

    }
    else if (type == 2)
    {

    }
    else if (type == 3)
    {

    }
    else if (type == 4)
    {

    }
    else if (type == 5)
    {

    }
    else if (type == 6)
    {

    }
    else if (type == 7)
    {

    }
    else if (type == 8)
    {

    }
    else if (type == 9)
    {

    }
    else
    {
        Console.WriteLine("Please contact Justin, there has been a bug in the program.");
    }
    Console.WriteLine("Enter 1 if you accept your mission.");
    Console.WriteLine("Enter 2 if you would like a different mission.");
    Console.WriteLine("Enter 0 to exit.");
    input = Console.ReadLine();
    if(Convert.ToInt32(input) == 0 )
    {
        continue;
    }
}
Console.WriteLine("Thanks for using the Ghost Recon Breakpoint Mission Generator created by Justin Zhao");