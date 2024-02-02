using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    //creating functions
    private static object animal;


    public void feed()
    {

    }


    public void playing()
    {

    }


    public void Resting()
    { 

    }


    public void CheckBodyStatus()
    {

    }




    static void MainUserDisplay()
    {
        Console.WriteLine("Main Menu\n");
        Console.WriteLine($"1.Feed ");
        Console.WriteLine($"2. Play with {animal}");
        Console.WriteLine("3. Let animal rest ");
        Console.WriteLine("4. check animal status ");
        Console.WriteLine("5. Exit ");
        string userInput = Console.ReadLine();
        int mainmenuResult = Int32.Parse(userInput);

        switch (userInput)
        {
            case "1":
                Console.WriteLine("You entered 1.");
                break;

            case "2":
                Console.WriteLine("You entered 2.");
                break;

            case "3":
                Console.WriteLine("You entered 3.");
                break;

            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                break;
        }
    }

    static void Main()
    {


        Console.WriteLine("***********Welcome to Virtual Pet Simulation**********");

  
       
        Console.Write("1. Cat\n");
        Console.Write("2. Dog\n");
        Console.Write("3. Rabbit\n");

       Console.Write("Choose the pet you want to raise by inputting the number\n\n");
        string firstoption = Console.ReadLine();
        int result = Int32.Parse(firstoption);








        //If user inputs valuee 1, then Cat is selected
        if (result==1)

        { 
            Console.Write("You've choosen Cat, what would you like to name it\n");
            string animal = Console.ReadLine();

            Console.WriteLine($"You have named him {animal}!, let's take good care of him.");
            mainmenu();
        }


//Making submenu


        int submenu;

        switch (submenu)
        {
            case 1:
                Feed();
                break;
            case 2:
            Playing();
                break;
            case 3:
                Resting();
                break;
            case 4:
                CheckBodyStatus();
                return;
        }





    }
}