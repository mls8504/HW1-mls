// Project: Text Adventure Game Heaven's Tower 
// Developed By: Megan Schier
// Purpose: To create a game that is a text adventure for the  player
// HW2 Update: Created classes for Welcome, the Locked door scenario, and for a dice roller. Created a check for a string to find the 3rd color and checked the step input for an int.
using System;

namespace SchierM_HW1
{
    class Program
    {
        public static void Welcome(string playerName)
        {
            Console.WriteLine("\t\tWelcome to Heaven's Tower " + playerName + ". Godspeed\n");
            Console.WriteLine("\t\t---------------------------------------------------");
            Console.WriteLine("\n After a long and treachourous journey, you have now reached ascension. Or have you? In this game you shall be judged of your sins and find your way to true peace. This game requires user Input.\n");
            Console.WriteLine(" Are you prepared to being your journey? (Y/N)\n");
            string input = Console.ReadLine().Trim().Substring(0, 1).ToUpper();
            if (input != "Y")
            {
                Console.WriteLine("You turn your back to the tower in fear, maybe one day you can ascend...\n");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
        public static void DoorLocked(string playerName)
        {
            Console.WriteLine(" You put your hand on the door handle to open the mysterious door as a voice booms into your head.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nBefore thou open this door " + playerName + ", you must find the key to prove thy worth");
        } 

        public static int DiceThrows()
        {
            int rollNum;
            Random myrandom = new Random();
            rollNum = myrandom.Next(1, 6);
            int firstNum = rollNum; 
            rollNum = myrandom.Next(1, 6);
            int totalNum = firstNum + rollNum;
            return totalNum;
        }
        static void Main(string[] args)
        {
            const string MY_COLORS = "blue,red,periwinkle,violet,maroon,orange,yellow,green";
            // Opening Screen
            string playerName;
            Console.WriteLine("Please Enter Player Name: ");
            playerName = Console.ReadLine().Trim();

            Welcome(playerName);
            
            // Start game 

            // Begin map 1 with narration 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            const int MAP1_STEPS = 42;
            string userSteps;
            int stepsTaken = 0;
            int stepsLeft;
            int extraSteps;
            Console.WriteLine("Your eyes flutter open to the sight of a grass hill and tall looking tower. The sky is grey and the surroundings carry no vibrant colors other than the clotes you don. You think to yourself how you got here and realize that you had just died. This is the next step. The tower calls out to you. It beckons you to come to it's doorstep.\n");
            Console.WriteLine("How many steps will you move to the tower enterance?");
            userSteps = Console.ReadLine();
            Boolean canParse = int.TryParse(userSteps, out stepsTaken); 
            if ( canParse == false)
            {
                Console.WriteLine("Please enter a valid Integer value");
                userSteps = Console.ReadLine(); 
            }
            if ( stepsTaken < MAP1_STEPS)
            {
                stepsLeft = MAP1_STEPS - stepsTaken;
                Console.WriteLine("The tower grows closer as an ominous wind pushes your back to the tower door. Fear shoots up your stare at the gothic styled tower.\n");

            } else if ( stepsTaken >= MAP1_STEPS)
            {
                extraSteps = stepsTaken - MAP1_STEPS;
                Console.WriteLine("You moved quite far. You have stopped at the door of the tower. Fear lingers in your spine at the tower grows ever bigger in your sight. Upon further notice, it has beautiful gothic actitecture but carries the aura of a modern building");
                if (extraSteps > 0)
                {
                    Console.WriteLine("\nYou moved " + extraSteps + "  steps past the door itself");
                }

            }

            DoorLocked(playerName);
            int numRolled = DiceThrows();
            if (numRolled > 4)
            {
                Console.WriteLine("\nThee have passed the first test " + playerName + ", now move forth and prove thy are worthy");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You rolled a " + numRolled);

                int number = MY_COLORS.IndexOf(',');
                number = MY_COLORS.IndexOf(',', number + 1);

                Console.WriteLine("As you step into the tower, a faint " + MY_COLORS.Substring(number, number + 1) + " light makes your surroundings visible"); 

            } 
            else
            {
                Console.WriteLine(" Thee hath failed the most simplest of tasks, thy shall not move forth");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You rolled a " + numRolled);
                Console.WriteLine("Lightning strikes down and chars your body into oblivion.........\n\t\tG A M E O V E R");
                Environment.Exit(-1);
            }
           
            // Map 1 is the enterance of tower with gates and a threatening sign 
            // Proceed to map 2  with more narration and character intro( level 1 of the tower) 
            // consists of bats and an imp i within the 4 small rooms filled with plot items and traps 
            // stairs found 
            // map 3 is found ( just a big spiral staircase with fake doors to try until the real one is found at the top) 
            // Enemies include more bats and gargoyles  
            // top floor reached ( map4) 
            // Final boss ( judgement & argument)  
            // End game

        }
    }
}
