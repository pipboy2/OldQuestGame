using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{


    class Program
    {


        public static void Main(string[] args)
        {
            //************************************
            //Title: (QuestWar)
            //Application Type: (Text based adventure game)
            //Description: (Fighting a skeleton)
            //Author: (Bruce Abshire)
            //Date Created: (12/06/2016)
            //Last Modified: (12/11/2016)
            //************************************


            //
            //Variables
            //

            int Arraycount = 0;
            int correct = 0;
            int Enemy_Health_Points;
            int Enemy_Maximum_Damage;
            int Player_One_Handed = 0;
            int Player_Two_Handed = 0;
            int Player_Ranged_Weapon = 0;
            int Player_Magic = 0;
            int Player_Quest_Progress = 0;
            int Player_Quest_Goal;
            int Player_EXP = 0;
            int Player_Attack_Type = 0;
            int Player_One_Weapon_Damage = 2;
            int Player_Health_Points = 20;
            int Player_Mana_Points = 12;
            int Quest_Reward_EXP;
            int Quest_Reward_Gold;


            string Player_Gender = " ";
            string Player_Race = " ";
            string Player_Class = " ";
            string Input;
            string Enemy_Name;
            string Player_Quest = " ";
            string Quest_Accepted;
            string Player_Quest_Enemy;

            string[] Stash = new string[20];

            //
            // Opening Screen
            //

            DisplayOpeningScreen();

            //
            //Character Creation:
            //

            while (correct == 0)
            {
                Console.Clear();
                Console.WriteLine("Please choose a gender for your character:");
                Console.Write("Male or Female: ");
                Player_Gender = Console.ReadLine().ToUpper();

                if (Player_Gender == "MALE" || Player_Gender == "FEMALE")
                {
                    correct = 1;
                }
                else
                {
                    Console.WriteLine("Please imput Male or Female.");
                    Console.WriteLine("Press any key to retry");
                    Console.ReadKey();
                }
            }

            correct = 0;

            //
            //Choose Race
            //

            while (correct == 0)
            {
                Console.Clear();
                Console.WriteLine("Please choose a race as below:");
                Console.WriteLine("Human");
                Console.WriteLine("Elf");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Orc");
                Console.Write("Your Choice: ");
                Player_Race = Console.ReadLine().ToUpper();

                if (Player_Race == "HUMAN")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 1 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();

                    if (Input == "YES")
                    {
                        correct = 1;
                    }

                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "DWARF")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();

                    if (Input == "YES")
                    {
                        correct = 1;
                    }

                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "ELF")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 0 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 2 Point");
                    Console.WriteLine("Magical Attack. 2 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "ORC")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 0 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                else
                {}
            }

            correct = 0;

            //
            //Class Creation
            //

            while (correct == 0)

            {
                Console.Clear();
                Console.WriteLine("Please choose a class as below:");
                Console.WriteLine("Warrior");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                Console.Write("Your Choice:");
                Player_Class = Console.ReadLine().ToUpper();

                if (Player_Class == "WARRIOR")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 0 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Class == "MAGE")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Class == "THIEF")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();

                    if (Input == "YES")
                    {
                        correct = 1;
                    }

                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                else
                {}
            }

            correct = 0;

            //
            //Bonuses and Race Bonus:
            //

            if (Player_Race == "HUMAN")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Player_Race == "DWARF")
            {
                Player_One_Handed++;
                Player_Two_Handed = Player_Two_Handed + 2;
                Player_Ranged_Weapon++;
            }
            if (Player_Race == "ELF")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                Player_Magic = Player_Magic + 2;
            }
            if (Player_Race == "ORC")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }

            //
            //Class Bonus:
            //

            if (Player_Class == "WARRIOR")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            if (Player_Class == "MAGE")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic = Player_Magic + 2;
            }
            if (Player_Class == "THIEF")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }

            //
            //Player info
            //

            Console.Clear();
            Console.WriteLine("Your Full Character Description, is:");
            Console.WriteLine("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
            Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
            Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
            Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
            Console.WriteLine("Magical Attack Skill Points: {0}", Player_Magic);
            Console.WriteLine();
            Console.WriteLine("Press enter to fight the dreaded Skeleton!!!");
            Console.ReadLine();



            Stash[0] = "Sword"; Stash[1] = "Knife"; Stash[2] = "Staff";

            Console.Clear();


            //Enemy Declair System:

            Enemy_Name = "Skeleton";
            Enemy_Health_Points = 12;
            Enemy_Maximum_Damage = 2;

            //Combat System:

            while (correct == 0)

            {
                correct = 0;
                Console.Clear();
                Player_Attack_Type = 0;
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
                Console.WriteLine();
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name, Enemy_Health_Points);
                Console.WriteLine();
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");

                if (!int.TryParse(Console.ReadLine(), out Player_Attack_Type))
                {
                    while (correct == 0)
                    {
                        Console.WriteLine("Please enter a number between 1 - 4");
                        Console.ReadLine();
                        if (Player_Attack_Type < 1 || Player_Attack_Type > 4)
                        {
                            correct = 1;
                        }
                    }
                    correct = 0;
                }

                if (Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Two_Handed);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Two_Handed);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
                    }
                    else { Player_Attack_Type = 0; }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                else { }
                if (Enemy_Health_Points > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                if (Enemy_Health_Points <= 0)
                {
                    correct = 1;
                }

                if (Player_Health_Points <= 0)
                {
                    correct = 1;
                }


                else { }
            }
            correct = 0;
            Console.Clear();

            if (Enemy_Health_Points < 0)
            {
                Enemy_Health_Points = 0;
            }

            if (Player_Health_Points < 0)
            {
                Player_Health_Points = 0;
            }

            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
            Console.WriteLine("The {0}s Healt is at {1} Points", Enemy_Name, Enemy_Health_Points);
            Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            Console.WriteLine("3. Ranged Weapon Attack");
            Console.WriteLine("4. Magical Attack");

            if (Enemy_Health_Points > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.WriteLine(" As you lay there with your life leaving you, the last thing you see is a");
                Console.WriteLine(" grinning and laughing skeleton as everything goes black...");
                Console.WriteLine();
                Console.WriteLine("***********GAME OVER************");
                Console.ReadLine();
                DisplayClosingScreen();                
                Environment.Exit(0);
            }

            if (Player_Health_Points > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.WriteLine();
                Console.WriteLine("Press enter to talk to the Cleric that just walked up.");
                Console.ReadLine();
            }

            //
            //Quest giving system:
            //

            Quest_Reward_EXP = 200;
            Quest_Reward_Gold = 100;
            Player_Quest_Goal = 2;
            Player_Quest_Enemy = "Skeletons";


            while (correct == 0)
            {

                correct = 0;
                Console.Clear();
                if (Player_Quest != " ")
                {
                    Console.WriteLine("You have to finish your current quest, in orden to get a new one.");
                    correct = 1;
                }

                if (Player_Quest == " ")
                {
                    Console.WriteLine("I would gladly pay you to kill the 3 Skeletons that plauge these lands.");
                    Console.WriteLine("Reward: {0} Gold, and {1} EXP", Quest_Reward_Gold, Quest_Reward_EXP);
                    Console.Write("Accept Yes/No:");
                    Input = Console.ReadLine().ToUpper();

                    if (Input == "NO")
                    {
                        correct = 1;
                        Quest_Accepted = "NO";
                        Console.WriteLine("You turn down the Clerics plea and walk away.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }

                    if (Input == "YES")
                    {
                        Console.WriteLine("The quest has been accepted.");
                        Console.WriteLine();
                        Player_Quest = "The farmer would gladly pay you 50 and give you 20 EXP, to rid his fields of the 3 Skeletons";
                        correct = 1;
                        Quest_Accepted = "YES";
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                }
            }
            correct = 0;

            //
            //Overworld Menu
            //

            while (correct == 0)
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Enter Quest, to see your current quests");
                Console.WriteLine("Enter Stash, to see your Inventory content");
                Console.WriteLine("Enter Self, to see details about your character");
                Console.WriteLine("Enter Exit, to quit the game");
                Input = Console.ReadLine().ToUpper();

                if (Input == "QUEST" && Player_Quest != " ")
                {

                    while (correct == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Player_Quest);
                        Console.WriteLine("Progress: {0}/{1} {2}", Player_Quest_Progress, Player_Quest_Goal, Player_Quest_Enemy);
                        Console.WriteLine("Enter Back");
                        Input = Console.ReadLine().ToUpper();

                        if (Input == "BACK")
                        {
                            correct = 1;
                        }

                        if (Input != "BACK")
                        {
                        }
                    }
                    correct = 0;
                }
                if (Input == "QUEST" && Player_Quest == " ")
                {
                    while (correct == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You don not have any active quests at the moment");
                        Console.WriteLine("Enter back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            correct = 1;
                        }
                        if (Input != "BACK")
                        {
                            correct = 0;
                        }
                    }
                    correct = 0;
                }
                if (Input == "STASH")
                {

                    while (correct == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Your Inventory Contains:");
                        for (Arraycount = 0; Arraycount < 20; Arraycount++)
                        {
                            int inventory_possition = Arraycount + 1;
                            Console.SetCursorPosition(0, inventory_possition);
                            Console.WriteLine("{0}", Stash[Arraycount]);
                        }
                        Console.WriteLine("Enter Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { correct = 1; }
                        if (Input != "BACK")
                        { correct = 0; }
                    }
                    correct = 0;
                }
                if (Input == "SELF" || Input == "ME")
                {
                    while (correct == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Your character is:");
                        Console.WriteLine("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
                        Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
                        Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
                        Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
                        Console.WriteLine("Magical Attack Skill Points: {0}", Player_Magic);
                        Console.WriteLine("{0} Health Points, {1} Mana Points, {2} Experience Points", Player_Health_Points, Player_Mana_Points, Player_EXP);
                        Console.WriteLine("Enter Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { correct = 1; }
                        if (Input != "BACK")
                        { correct = 0; }
                    }
                    correct = 0;
                }
                if (Input == "EXIT" || Input == "QUIT")
                {
                    DisplayClosingScreen();
                    correct = 1;
                }
                else
                {
                }
            }
        }

        static void DisplayContinuePrompt()
        {
            //
            // display continue prompt
            //
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void DisplayOpeningScreen()
        {
            //
            // display an opening screen
            //
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                           Welcome to Quest War!!!");
            Console.WriteLine("                               By: Bruce Abshire");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  This is a short text based adventure game");
            Console.WriteLine("       You will be creating a characters race and class and fighting a skeleton");
            Console.WriteLine("                         your abilities. Good luck!");

            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            //
            // display a closing screen
            //
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for playing my short game!");
            Console.WriteLine();
            Console.WriteLine();

            //
            // dsiplay continue prompt
            //
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
