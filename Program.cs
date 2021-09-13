using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_Opgave
{
    class Program
    {
        #region Automat ASCII art and menu templates
        static string n1 = "\n              1.";
        static string n2 = "\n              2.";
        static string n3 = "\n              3.";
        static string n4 = "\n              4.";
        static string n5 = "\n              5.";
        static string n6 = "\n              6.";

        static string lineTemplate =
"\n------------------------------------------";

        static string automatTemplate = 

@"------------------------------------------
   ___         __                     __ 
  / _ | __ __ / /_ ___   __ _  ___ _ / /_
 / __ |/ // // __// _ \ /  ' \/ _ `// __/
/_/ |_|\_,_/ \__/ \___//_/_/_/\_,_/ \__/ 
                                          
------------------------------------------";
        #endregion

        #region Collection of static methods

        #region Start menu
        static void Main(string[] args)
        {
            // A boolean to control the menu
            bool startMenu = true;

            // Test
            string itemAmount = "";
            string totalPrice = "";

            // While loop so we easily can exit the program with our showMenu bool
            while (startMenu == true)
            {
                // Sets the console width and height to the selected int values
                Console.SetWindowSize(42, 28);

                // Start GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} Candy");
                Console.WriteLine($"{n2} Juice");
                Console.WriteLine($"{n3} Soda");
                Console.WriteLine($"{n4} Payment options");
                Console.WriteLine($"{n5} Remove all items");
                Console.WriteLine($"{n6} Exit");
                Console.WriteLine(lineTemplate);
                Console.WriteLine($"\n         Total amount of items: {itemAmount}");
                Console.WriteLine($"\n                Price: {totalPrice}");
                Console.Write("\n       Choose a menu by the number: ");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        CandySelection();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        JuiceSelection();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        SodaSelection();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        PaymentOptions();
                        Console.Clear();
                        break;
                    case "5":
                        // Remove all items from the list
                    case "6":
                        startMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Candy menu
        // Static so we can use it from Main, void since no need to return any datatype
        static void CandySelection()
        {
            // Bool to control the menu
            bool candyMenu = true;

            // While loop so we easily can exit the program with our candyMenu bool
            while (candyMenu == true)
            {
                // Candy GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} Chocolate bar");
                Console.WriteLine($"{n2} Granola bar");
                Console.WriteLine($"{n3} Lollipop");
                Console.WriteLine($"{n4} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.Write("\n\n      Choose an item by the number: ");                

                switch (Console.ReadLine())
                {
                    case "1":
                        // Add class object to a list, give feedback if added succesfully
                        break;
                    case "2":
                        // 
                        break;
                    case "3":
                        // 
                        break;
                    case "4":
                        candyMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Juice menu
        static void JuiceSelection()
        {
            // Bool to control the menu
            bool juiceMenu = true;

            // While loop so we easily can exit the program with our juiceMenu bool
            while (juiceMenu == true)
            {
                // Juice GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} Apple juice");
                Console.WriteLine($"{n2} Mango juice");
                Console.WriteLine($"{n3} Orange juice");
                Console.WriteLine($"{n4} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.Write("\n\n      Choose an item by the number: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // Add class object to a list, give feedback if added succesfully
                        break;
                    case "2":
                        // 
                        break;
                    case "3":
                        // 
                        break;
                    case "4":
                        juiceMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Soda menu
        static void SodaSelection()
        {
            // Bool to control the menu
            bool sodaMenu = true;

            // While loop so we easily can exit the program with our sodaMenu bool
            while (sodaMenu == true)
            {
                // Soda GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine();
                Console.WriteLine($"{n1} Cola");
                Console.WriteLine($"{n2} Sparkling water");
                Console.WriteLine($"{n3} Sports drink");
                Console.WriteLine($"{n4} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.Write("\n\n      Choose an item by the number: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // Add class object to a list, give feedback if added succesfully
                        break;
                    case "2":
                        // 
                        break;
                    case "3":
                        // 
                        break;
                    case "4":
                        sodaMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Payment menu
        static void PaymentOptions()
        {
            // Bool to control the menu
            bool paymentMenu = true;

            // While loop so we easily can exit the program with our paymentMenu bool
            while (paymentMenu == true)
            {
                // Payment GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} Cash");
                Console.WriteLine($"{n2} Creditcard");
                Console.WriteLine($"{n3} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.Write("\n\n         Choose payment option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        CashMenu();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        CreditcardMenu();
                        Console.Clear();
                        break;
                    case "3":
                        paymentMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Cash menu
        static void CashMenu()
        {
            // Bool to control the menu
            bool cashMenu = true;

            // Test
            string itemAmount = "";
            string totalPrice = "";

            // While loop so we easily can exit the program with our cashMenu bool
            while (cashMenu == true)
            {
                // Cash GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} ");
                Console.WriteLine($"{n2} ");
                Console.WriteLine($"{n3} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.WriteLine($"\n\n         Total amount of items: {itemAmount}");
                Console.WriteLine($"\n\n                Price: {totalPrice}");
                Console.Write("\n\n         Choose payment option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // 
                        break;
                    case "2":
                        // 
                        break;
                    case "3":
                        cashMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Creditcard menu
        static void CreditcardMenu()
        {
            // Bool to control the menu
            bool creditcardMenu = true;

            // Test
            string itemAmount = "";
            string totalPrice = "";

            // While loop so we easily can exit the program with our creditcardMenu bool
            while (creditcardMenu == true)
            {
                // Creditcard GUI
                Console.WriteLine(automatTemplate);
                Console.WriteLine($"{n1} ");
                Console.WriteLine($"{n2} ");
                Console.WriteLine($"{n3} Previous menu");
                Console.WriteLine(lineTemplate);
                Console.WriteLine($"\n\n         Total amount of items: {itemAmount}");
                Console.WriteLine($"\n\n                Price: {totalPrice}");
                Console.Write("\n\n         Choose payment option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // 
                        break;
                    case "2":
                        // 
                        break;
                    case "3":
                        creditcardMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #endregion
    }
}

// Undersøg hvordan karakterer skjules når de skrives til pin kode

// Lav en manager class til at forbinde lagene

// Lav en class med logik til pris udregning

// Lav en class der hedder ConsumerProduct med navn og pris som attributes

// Dal lag der gemmer kvittering som .txt fil til regnskab