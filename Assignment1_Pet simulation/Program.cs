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







    public void feeding()
    {
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);
        Console.WriteLine($"{name} has been fed. Hunger decreased, and health increased.\n");
    }


    public void playing()
    {
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
        Console.WriteLine($"{name} has played. Happiness increased, and hunger slightly increased.\n");
    }


    public void resting()
    {
        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
        Console.WriteLine($"{name} has rested. Health increased, and happiness slightly decreased.\n");
    }



    public void CheckBodyStatus()
    {


    }




    static void MainUserDisplay()
    {

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

            if (mainmenuResult < 1 || mainmenuResult > 4)
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

        Console.Write("Give your pet a name: ");
        name = Console.ReadLine();

    }

}

}


class Program
{
static void Main()
{

   

    VirtualPet myPet = new VirtualPet();
        myPet.mainmenu();
       









    }

}