/**
* Date
* CSC 153
* Drew Tadlock
* Create a menu to display some rooms, weapons, potion, treasures, items, mobs, and an exit
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_1
{
    class Program
    {
        // in the future, for weapons, treasure, items, etc. store description as a separate variable to show them, ex: treasure2 = "Item Upgrade Scroll", treasure2Desc = "Upgrade an item's effects by 20%, Potion's effects by 75% at an upgrade station"

        static String room1 = "Entrance";
        static String room2 = "Mob Room";
        static String room3 = "Treasure Room";
        static String room4 = "Mob Room";
        static String room5 = "Boss Room";

        static String weapon1 = "Longsword (5 melee damage, 2 handed)";
        static String weapon2 = "Bow (3 ranged damage, 2 handed)";
        static String weapon3 = "Spear (4 melee damage, 1 handed)";
        static String weapon4 = "Shortsword (4 melee damage, 1 handed)";

        static String potion1 = "Healing Potion (+10 hp)";
        static String potion2 = "Strength Potion (next 3 attacks do 1.5x damage)";

        static String treasure1 = "10 gold"; // maybe something with currency in the future, like merchants
        static String treasure2 = "Item Upgrade Scroll (Upgrade an item's effects by 20%, Potion's effects by 75% at an upgrade station)";
        static String treasure3 = "Life Saver (Receive 20% max hp back instead of dying)";

        static String item1 = "Arrow";
        static String item2 = "Shield (25% chance to block an attack, can only be used with a 1 handed item)";
        static String item3 = "Dynamite (8 AOE damage)";
        static String item4 = "Ring of Attack (adds 3 damage to all attacks)";

        static String mob1 = "Zombie";
        static String mob2 = "Mage";
        static String mob3 = "Archer";
        static String mob4 = "Dragon Boss";

        static void Main(string[] args)
        {
            Menu(true);
        }

        static void Menu(bool showOptions)
        {
            if (showOptions)
            {
                Console.WriteLine("1. Rooms");
                Console.WriteLine("2. Weapons");
                Console.WriteLine("3. Potions");
                Console.WriteLine("4. Treasure");
                Console.WriteLine("5. Items");
                Console.WriteLine("6. Mobs");
            }
            Console.WriteLine("Type an Option:");
            String option = Console.ReadLine().ToLower();
            bool input = MenuInput(option);
            if (input == false)
            {
                Menu(true);
            }
            else
            {
                Menu(false);
            }
        }

        static bool MenuInput(String input)
        {
            // in the future, accept "room 1", "weapon 1", "potion 1", etc for an explanation of what each does and more details
            if (input == "1" || input.Contains("roo"))
            {
                Console.WriteLine("Room 1: " + room1);
                Console.WriteLine("Room 2: " + room2);
                Console.WriteLine("Room 3: " + room3);
                Console.WriteLine("Room 4: " + room4);
                Console.WriteLine("Room 5: " + room5);
            }
            else if (input == "2" || input.Contains("weap"))
            {
                Console.WriteLine("Weapon 1: " + weapon1);
                Console.WriteLine("Weapon 2: " + weapon2);
                Console.WriteLine("Weapon 3: " + weapon3);
                Console.WriteLine("Weapon 4: " + weapon4);
            }
            else if (input == "3" || input.Contains("pot"))
            {
                Console.WriteLine("Potion 1: " + potion1);
                Console.WriteLine("Potion 2: " + potion2);
            }
            else if (input == "4" || input.Contains("tre"))
            {
                Console.WriteLine("Treasure 1: " + treasure1);
                Console.WriteLine("Treasure 2: " + treasure2);
                Console.WriteLine("Treasure 3: " + treasure3);
            }
            else if (input == "5" || input.Contains("ite"))
            {
                Console.WriteLine("Item 1: " + item1);
                Console.WriteLine("Item 2: " + item2);
                Console.WriteLine("Item 3: " + item3);
                Console.WriteLine("Item 4: " + item4);
            }
            else if (input == "6" || input.Contains("mob"))
            {
                Console.WriteLine("Mob 1: " + mob1);
                Console.WriteLine("Mob 2: " + mob2);
                Console.WriteLine("Mob 3: " + mob3);
                Console.WriteLine("Mob 4: " + mob4);
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
