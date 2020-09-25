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
            Console.WriteLine("Your eyes flutter open to the sight of a grass hill and tall looking tower. The sky is grey and the surroundings carry no vibrant colors other than the clothes you don. You think to yourself how you got here and realize that you had just died. This is the next step. The tower calls out to you. It beckons you to come to it's doorstep.\n");
            Console.WriteLine("How many steps will you move to the tower enterance?");
            userSteps = Console.ReadLine();
            Boolean canParse = int.TryParse(userSteps, out stepsTaken); 
            if ( canParse == false)
            {
                Console.WriteLine("Please enter a valid Integer value");
                userSteps = Console.ReadLine(); 
            }
            // Step checker for first area
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

            // Dice roll to determine if moving on or not
            DoorLocked(playerName);
            int numRolled = DiceThrows();
            if (numRolled > 4)
            {
                Console.WriteLine("\nThee have passed the first test " + playerName + ", now move forth and prove thy are worthy");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You rolled a " + numRolled);

                int number = MY_COLORS.IndexOf(',');
                number = MY_COLORS.IndexOf(',', number + 1);

                Console.WriteLine("As you step into the tower, a faint " + MY_COLORS.Substring(number, number + 3) + " light makes your surroundings visible"); 

            } 
            else
            {
                Console.WriteLine(" Thee hath failed the most simplest of tasks, thy shall not move forth");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You rolled a " + numRolled);
                Console.WriteLine("Lightning strikes down and chars your body into oblivion.........\n\t\tG A M E O V E R");
                Environment.Exit(-1);
            }

          // Tower floor 1
            BldgRooms();
            BldgRooms();
            BldgRooms();
            BldgRooms();
            BldgRooms();

            // Tower basement call
            BasementRooms();
            BasementRooms();
            BasementRooms();
            BasementRooms();



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
        public static void BldgRooms() // Write descriptions
        {
            string roomNum;
            int numRoom;
            Console.WriteLine("You see 5 rooms strected out along the sides of the tower wall. Which room wil you venture to first? \n Please enter a number 1-5.");
            roomNum = Console.ReadLine().Trim();
            Boolean isParse = int.TryParse(roomNum, out numRoom);
            if (isParse == false)
            {
                Console.WriteLine(" Please enter a valid number room");

            }
            numRoom.ToString(roomNum);
            
                switch (roomNum)
                {
                    case "1":
                        Console.WriteLine("You open the first door to find a sea of books spread out upon you. The floor barely visible as the sea of books devour you. With a closer inspection, you seee all the books pertain to all different religions. The walls seem to never end as shelves of books upon books stretch out. It seems nothing here will help you.");
                        break;
                    case "2":
                        Console.WriteLine("You open the second door to find a bare room, there is little decoration in this room other than resident dust bunnies and one rocking chair that seems to move every couple seconds. Keeping your goosebumps in check, you find nothing of use in this room.");
                        break;
                    case "3":
                        Console.WriteLine("You open the third door to find quite the different change in atmosphere. The walls are not like walls but as trees and the ground was a soft grass floor. A small pond sat in the middle of the pond. You look into the small pond to find yourself reflected in the crystal water. You're still you! But this is all you gain from this so you can keep moving forth.");
                        break;
                    case "4":
                        Console.WriteLine("You find the fourth door not to open at first but after a few hard pushes, the door gives in to reveal a room filled with spiderwebs... or cobwebs? You honestly cannot tell the difference but your arachnaphobia boots you out of the room before you can find out. ");
                        break;
                    case "5":
                        Console.WriteLine("You swing open the fifth door to a more normal looking room. There's a small bookshelf on the wall filled with more religion (B)ooks, a (L)ever next to a lamp, and a small indoor garden with many (F)lowers. Which one will you observe first? (Or press Q to quit) ");
                        string itemSelect = Console.ReadLine().Trim().ToUpper();
                        if (itemSelect == "B")
                        {
                            Console.WriteLine("You go over and inspect the books closer to find all the books are the same volume with no change. There isn't anything else really here of importance other than knowledge.");
                        }
                        else if (itemSelect == "L")
                        {
                            Console.WriteLine("You go over and cautiously look at the lever near the lamp. You flick it and prepare for something horrible but no. The lamp is now on.");
 
                        }
                        else if (itemSelect == "F")
                        {
                            Console.WriteLine("You go to inspect the flowers and all of them are quite well kept. One red Poppy especially. It is really full, like supernaturally. You go to touch the petals to find the flower to be a fake. You remove the flower from the ground and the ground shakes open to a staircase spiraling downward. You have reached the next level.");
                        }
                        else if (itemSelect == "Q")
                        {
                            Console.WriteLine("Maybe next time....\n\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } else
                        {
                            Console.WriteLine(" Enter a correct item to observe.");
                        }

                        break;

                }
            
        }

        public static void BasementRooms() // Each room has a challenge + write descriptions
        {
            string roomNum;
            int numRoom;
            Console.WriteLine("The ground opens up to 4 larger rooms that spread across. Which room wil you venture to first? \n Please enter a number 1-4.");
            roomNum = Console.ReadLine().Trim();
            Boolean isParse = int.TryParse(roomNum, out numRoom);
            if (isParse == false)
            {
                Console.WriteLine(" Please enter a valid number room");

            }

            numRoom.ToString(roomNum);
                switch (roomNum)
                {
                    case "1":
                        Console.WriteLine("The first room widens up to reveal a larger atmosphere than the rooms you saw before. The walls are dark and a single pedestal sits in the middle, upon further inspection, there sits 3 rocks on a small platform. One is (D)ull, the next is (R)ough with a hard,dark exterior, and the third is (P)ainted with small paint marks making the shape of angel wings. Which will you pick up? ( or Q to quit) ");
                        string itemSelect = Console.ReadLine().Trim().ToUpper();
                        if (itemSelect == "D")
                        {
                            Console.WriteLine("You pick up the dull rock and inspect it further, it's just a rock but deep within it you can see a small glow. This glow is enough for you to see the door on the other side of the room. With your dim rock of hope, you pass through the next door.");
                        break;
                        }
                        else if (itemSelect == "R")
                        {
                            Console.WriteLine("You pick up the rough rock and inspect it further, this Igneous rock seems to still be warm with magma inside. Before you get to look at it more, the ground opens up beneath you and you fall down a seemlessy never ending hole....\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        }
                        else if (itemSelect == "P")
                        {
                            Console.WriteLine("You greedily grasp at the painted rock only to find it slowly chipping, the once white exterior turns to grey and light slowly fades from the room. As darkness settles in, you find no exit and stay in the room forever...\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        }
                        else if (itemSelect == "Q") 
                        {
                            Console.WriteLine("Maybe next time....\n\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else
                        {
                            Console.WriteLine("Please enter a valid object to inspect of Q to Quit");
                        }
                       break;
                    case "2":
                        Console.WriteLine("You enter the second room to find a very tiny room and a singular tree with apples upon its branches, an axe by the trunk, and a door at the other side of the room. The old tree is healthy and strong despite it's dark room and the apples look extremely delicious. It also looks like the tree would be a great spot to nap on it's branches. This would be a nice place to eat an apple and sleep wouldn't it? What would you like to do? Pick an (A)pple, cut down the tree with the a(X)e, or go to the (D)oor? ( Can also press Q to quit)");
                        string itemselect = Console.ReadLine().Trim().ToUpper();
                        if (itemselect == "A")
                        {
                            Console.WriteLine("You reach your hand to pick one of the ripe apples and take a bite. At first, the apple tastes delicious and is the best apple you have ever had. When suddenly, the apple's taste turns to a sour and the apple itself disignigrates into your palm. The feeling spreads throughout your body until you too fall to the floor to be more nutrients for the tree to feed upon...\t\t G A M E O V E R");
                        Environment.Exit(-1);
                        } 
                        else if ( itemselect == "X")
                        {
                            Console.WriteLine("You grab the axe with a tight grip and take a deep breath before striking down the tree. The apples fall as you tear into the bark of the old tree. You hear a crack before the tree snaps in half and falls directly onto you, squashing your body...\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else if ( itemselect == "D")
                        {
                            Console.WriteLine(" You move straight pass the tree and the axe right to the door. You grad the handle to suprisingly just find the door to be open. You step through the wooden door to the next room.");
                            break; 
                        }
                        else if ( itemselect == "Q")
                        {
                            Console.WriteLine("Maybe next time....\n\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else
                        {
                            Console.WriteLine("Please enter a valid object to inspect of Q to Quit");
                        }
                        break;
                       
                    case "3":
                        Console.WriteLine("The next room is a plain room once again with a large pattern inscribed into the wall. The patterns are massive against the stone surface but are simplistic in nature. The patterns has the inscribed patterns for earth, air, and water. There seems to be a spot left for one more symbol. Under the blank slate of rock, there is a small art board with new patterns on the board. There three symbols are as follows: (F)ire, (L)ightning, and (P)lasma. Which one is next in the giant wall pattern? ( or press Q to quit)");
                        itemSelect = Console.ReadLine().Trim().ToUpper(); 
                        if ( itemSelect == "F")
                        {
                            Console.WriteLine("You point to the fire pattern and speak it's name. The wall then suddenly seems to burn up and as the rock melts into a fiery lava, a doorway appears for you to move forward. You step over the hot lava and move past the door way to the final room.");
                            break; 
                        } 
                        else if ( itemSelect == "L")
                        {
                            Console.WriteLine("You point to the lightning pattern and hear a crack of thunder overhead. You look up to see storm clouds appearing over you and small lightning circling overhead. A flash of light blinds you as you feel your body start to heat up then cool almost instantly as you fall to the ground fried...\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else if ( itemSelect == "P")
                        {
                            Console.WriteLine("You point to the plasma symbol and see the pattern start to move. The more you look around, the more small dots you see moving extremely fast almost to the speed of light. You reach a hand out and a particle ghits your hand almost taking off you hand.The amount of particles grow larger as they hit your body and you fall like a piece of swiss cheese...\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else if ( itemSelect == "Q")
                        {
                            Console.WriteLine("Maybe next time....\n\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        } 
                        else
                        {
                            Console.WriteLine("Please enter a valid object to inspect of Q to Quit");
                        }
                       break; 
                    case "4":
                        Console.WriteLine("The final room is the largest so far, in the center ( and taking up most of the room) is a large scale. This scale is unbalanced as one side is down. You look at the down side and see a heart within the tray, you look at your chest to find your heart gone. So it's safe for you to deduct that your heart is on the scale. Near the other tray is 2 objects, a (F)eather, or a rock (R). You can either leave the space (E)mpty or fill it with an object. What will you do? ( of press Q to quit)");
                        itemSelect = Console.ReadLine().Trim().ToUpper();
                        if (itemSelect == "F")
                        {
                            Console.WriteLine("You lift the feather onto the scale, expecting no movement but instead the scales balance out. Your heart and the feather are the same weight. Suddenly, light appears from a part of the wall and an archway is carved through the wall. It glows of a heavenly glow.... you walk through....");
                           break;
                        }
                        else if (itemSelect == "R")
                        {
                            Console.WriteLine("You throw the rock onto the scale and the tray with the rock is pushed down, your heart flies off the other tray from the forcce and smashes on the ground as your body follows...\t\t  G A M E O V E R");
                            Environment.Exit(-1); 
                        }
                        else if (itemSelect == "E")
                        {
                            Console.WriteLine("You leave the tray empty and nothing happens..... you sit there waiting for something to happen but nothing does.....you sit in boredorm for the rest of your days...\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        }
                        else if (itemSelect == "Q")
                        {
                            Console.WriteLine("Maybe next time....\n\t\t G A M E O V E R");
                            Environment.Exit(-1);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid object to inspect of Q to Quit");
                        }
                        break;
                }
            
            return;
        }
    }
}
