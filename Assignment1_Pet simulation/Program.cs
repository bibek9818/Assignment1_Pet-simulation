using System;


class VirtualPetClass
{
  
    public string VirtualPetType;
    public string VirtualPetName;
    public int PetHunger = 5;
    public int PetHappiness = 5;
    public int PetHealth = 5;


    //Decreases hunger, slightly increases health.
    public void feeding()
    {
        PetHunger = Math.Max(0, PetHunger - 2);
        PetHealth = Math.Min(10, PetHealth + 1);
        Console.WriteLine($"{VirtualPetName} has been fed. Hunger decreased, and health increased.\n");
    }

    //Increases happiness, slightly increases hunger.
    public void playing()
    {
        PetHappiness = Math.Min(10, PetHappiness + 2);
        PetHunger = Math.Min(10, PetHunger + 1);
        Console.WriteLine($"{VirtualPetName} has played. Happiness increased, and hunger slightly increased.\n");
    }

    //Improves health, decreases happiness slightly.
    public void resting()
    {
        PetHealth = Math.Min(10, PetHealth + 2);
        PetHappiness = Math.Max(0, PetHappiness - 1);
        Console.WriteLine($"{VirtualPetName} has rested. Health increased, and happiness slightly decreased.\n");
    }


    //•	Track and display pet’s stats: hunger, happiness, and health, each on a scale of 1 to 10.
    public void CheckBodyStatus()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine($"****Pet Type: {VirtualPetType}\tPet Name: {VirtualPetName}****");
        Console.WriteLine($"****Hunger: {PetHunger}/10\tHappiness: {PetHappiness}/10\t\tHealth: {PetHealth}/10****\n");

         

    }

    //Simulate the passage of time, where each action represents the passing of an hour.
    public void PassageofTime()
    {
        PetHunger += 1;
        PetHappiness -= 1;

 
        if (PetHunger >= 8)
        {
            PetHealth = Math.Max(0, PetHealth - 2);
            Console.WriteLine($"{VirtualPetName} is very hungry. Health is decreasing.\n");
        }

        if (PetHappiness <= 2)
        {
            Console.WriteLine($"{VirtualPetName} is very unhappy. Consider playing with {VirtualPetName}.\n");
        }
    }




    //Submenu for selecting pet actions
    public void submenu()
    {
       

        while (true)
        {
            Console.WriteLine("\n\n");
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
            PassageofTime();
        }
    }


    // Main Entrance to pick the Virtual Pet
    public void PickVirtualPet()
    {
     
        Console.WriteLine("1. Cat\n");
        Console.WriteLine("2. Dog\n");
        Console.WriteLine("3. Rabbit\n");
        Console.WriteLine("Choose the pet you want to raise by inputting the number\n\n");
     
        string firstoption = Console.ReadLine();
        int PickPet = Int32.Parse(firstoption);



        if (PickPet >= 1 && PickPet <= 3)
        {
            switch (PickPet)
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
        Console.WriteLine($"You have choosen {VirtualPetType}, what would you like to name your pet? : \n");

        VirtualPetName = Console.ReadLine();
        Console.WriteLine("\n\n");

        Console.WriteLine($"You've chosen a {VirtualPetType} named {VirtualPetName} , Let's take good care of him!\n\n");

    }

}


class Program
{
    //This is the main function that is being executed.
static void Main()
{

    VirtualPetClass Objpet = new VirtualPetClass();
        Objpet.mainmenu();
        Objpet.submenu();


    }

}