using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class VirtualPet
{
    //  public string VirtualPetType;
    //  public string VirtualPetName;
    public string type;
    public string name;
    public int hunger = 5;
    public int happiness = 5;
    public int health = 5;






    //Decreases hunger, slightly increases health.
    public void feeding()
    {
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);
        Console.WriteLine($"{name} has been fed. Hunger decreased, and health increased.\n");
    }

    //Increases happiness, slightly increases hunger.
    public void playing()
    {
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
        Console.WriteLine($"{name} has played. Happiness increased, and hunger slightly increased.\n");
    }

    //Improves health, decreases happiness slightly.
    public void resting()
    {
        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
        Console.WriteLine($"{name} has rested. Health increased, and happiness slightly decreased.\n");
    }


    //•	Track and display pet’s stats: hunger, happiness, and health, each on a scale of 1 to 10.
    public void CheckBodyStatus()
    {
        Console.WriteLine($"Pet Type: {type}\tPet Name: {name}");
        Console.WriteLine($"Hunger: {hunger}/10\tHappiness: {happiness}/10\tHealth: {health}/10\n");

         

    }

    //Simulate the passage of time, where each action represents the passing of an hour.
    public void PassageofTime()
    {
        hunger += 1;
        happiness -= 1;

        // Check for consequences of neglect
        if (hunger >= 8)
        {
            health = Math.Max(0, health - 2);
            Console.WriteLine($"{name} is very hungry. Health is decreasing.\n");
        }

        if (happiness <= 2)
        {
            Console.WriteLine($"{name} is very unhappy. Consider playing with {name}.\n");
        }
    }






    //Making submenu
    public void submenu()
    {
       

        while (true)
        {
            // DisplayStatus();
            Console.WriteLine("Main Menu :\n");
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Rest the pet");
            Console.WriteLine("4. Check the pet status");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the input :   ");


            string userInput = Console.ReadLine();
            int mainmenuResult = Int32.Parse(userInput);
       //     Console.WriteLine($"User Input : {mainmenuResult} ");
       

            if (mainmenuResult < 1 || mainmenuResult > 5)
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
                        resting();
                        break;
                    case 4:
                        CheckBodyStatus();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:

                        return;
                }
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


       // Console.WriteLine($"User Inputted : {result}");

      




        //Console.WriteLine("The current status of the virtual pet is :\n");
        //CheckBodyStatus();


        if (result >= 1 && result <= 3)
        {
            switch (result)
            {
                case 1:
                    type = "Cat";
                    break;
                case 2:
                    type = "Dog";
                    break;
                case 3:
                    type = "Rabbit";
                    break;

            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        }


    }



    public void mainmenu()
    {
        Console.WriteLine("***********Welcome to Virtual Pet Simulation**********");


        PickVirtualPet();
        Console.WriteLine("\n\n");
        Console.WriteLine($"You have choosen {type}, what would you like to name your pet? : \n");

        name = Console.ReadLine();
        Console.WriteLine("\n\n");

        Console.WriteLine($"You've chosen a {type} named {name} , Let's take good care of him!\n\n");

    }

}




class Program
{
static void Main()
{

    VirtualPet myPet = new VirtualPet();
        myPet.mainmenu();
        myPet.submenu();


    }

}