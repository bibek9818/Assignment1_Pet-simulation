using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class VirtualFucntions
{
    public string VirtualPetType;
    public string VirtualPetName;


    public VirtualPet(string type, string name)
    {
        Type = type;
        Name = name;
       /* Hunger = 5;     // Initial values for hunger, happiness, and health
        Happiness = 5;
        Health = 5;*/
    }


    //creating functions
    private static object animal;


    public void feeding()
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

    //Making submenu
    public void submenu()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        while (true)
        {
           // DisplayStatus();

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Rest the pet");
            Console.WriteLine("4. Check the pet status");
            Console.WriteLine("5. Exit");


            string userInput = Console.ReadLine();
            int mainmenuResult = Int32.Parse(userInput);

            int choice;

            if(mainmenuResult<1 || mainmenuResult>4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
            else
            switch (mainmenuResult)
            {
                case 1:
                    feeding();
                    break;
                case 2:
                    playing();
                    break;
                case 3:
                    Resting();
                    break;
                case 4:
                        CheckBodyStatus();
                    break;
                default:
                       
                    return;
                }

        //    TimePasses();  Simulate the passage of time
        }
    }



    public void PickVirtualPet()
    {

        Console.WriteLine("1. Cat\n");
        Console.WriteLine("2. Dog\n");
        Console.WriteLine("3. Rabbit\n");
        Console.WriteLine("Choose the pet you want to raise by inputting the number\n\n");
        string firstoption = Console.ReadLine();
        int result = Int32.Parse(firstoption);


        if(result>=1 && result<=3)
        {
            switch(result)
            {
                case 1:
                    VirtualPetType = "Cat";
                    break;
                case 2:
                    VirtualPetType = "Dog";
                    break;
                case 3:
                    VirtualPetType = "Rabbit";
                    break;

            }
        }


    }



    public void mainmenu()
    {
        Console.WriteLine("***********Welcome to Virtual Pet Simulation**********");


        PickVirtualPet();

        Console.Write("Give your pet a name: ");
        string petName = Console.ReadLine();

    }



}
class Program
{
static void Main()
{

   

    VirtualPet myPet = new VirtualPet();











    //If user inputs valuee 1, then Cat is selected
    if (result == 1)

    {
        Console.Write("You've choosen Cat, what would you like to name it\n");
        string animal = Console.ReadLine();

        Console.WriteLine($"You have named him {animal}!, let's take good care of him.");
        mainmenu();
    }



    }

}