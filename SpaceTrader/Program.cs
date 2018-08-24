using System;
using System.Collections.Generic;

namespace SpaceTrader
{
    class Program
    {
        static double userMoney = 1000;
        static int userCargo = 0;
        static double timeTrav = 0;
        static double moneyTotal = 0;
        static int planetSelection = 0;

        static void Main(string[] args)
        {
            
            Travel();
          
        }

        static void GameStory()
        {
            string[] directions = System.IO.File.ReadAllLines(@"c:\users\wwstudent\Source\Repos\SpaceTrader\SpaceTrader\GameStory.txt");
        }
        static void GameDirections()
        {
            string[] directions = System.IO.File.ReadAllLines(@"c: \users\wwstudent\Source\Repos\SpaceTrader\SpaceTrader\GameDirections.txt");
        }

        static void UserStats()
        {

        }

        static void MainMenuEarth()
        {

            Console.WriteLine("Welcome to Earth! What would you like to do?");
            Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel or Type 4 to view Player stats");
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BuyMenuEarth();
            }
            else if (userSelection == 2)
            {
                SellMenuEarth();
            }
            else if (userSelection == 3)
            {
                Travel();
            }
            else if (userSelection == 4)
            {
                UserStats();
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option.");
            }
        }

        static void MainMenuAlpha()
        {

            Console.WriteLine("Welcome to Alpha Centauri! What would you like to do?");
            Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel or Type 4 to view Player stats");
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BuyMenuAlpha();
            }
            else if (userSelection == 2)
            {
                SellMenuAlpha();
            }
            else if (userSelection == 3)
            {
                Travel();
            }
            else if (userSelection == 4)
            {
                UserStats();
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option.");
            }
        }

        static void MainMenuPluto()
        {

            Console.WriteLine("Welcome to Pluto! What would you like to do?");
            Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel or Type 4 to view Player stats");
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BuyMenuPluto();
            }
            else if (userSelection == 2)
            {
                SellMenuPluto();
            }
            else if (userSelection == 3)
            {
                Travel();
            }
            else if (userSelection == 4)
            {
                UserStats();
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option.");
            }
        }

        static void BuyMenuEarth()
        {
            
                Console.WriteLine("What would you like to purchase?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $200 Cargo space = 1", "Type 1 for Gold $300 Cargo space = 2",
                "Type 2 for Diamond $500 Cargo space = 3" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                    Console.WriteLine(cargoItem);
                }
                int userPurchaseEarth = int.Parse(Console.ReadLine());


                if (userPurchaseEarth == 0)
                {
                    userMoney -= 200;
                }
                else if (userPurchaseEarth == 1)
                {
                    userMoney -= 300;
                }
                else if (userPurchaseEarth == 2)
                {
                    userMoney -= 500;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select an option");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.ReadLine();
        }

        static void BuyMenuAlpha()
        {
            Console.WriteLine("What would you like to purchase?");
            List<string> menu = new List<string>();
            string[] cargoItems = { "Type 0 for Silver $100 Cargo space = 1", "Type 1 for Gold $400 Cargo space = 2",
                "Type 2 for Diamond $300 Cargo space = 3" };
            menu.AddRange(cargoItems);
            foreach (string cargoItem in menu)
            {
                Console.WriteLine(cargoItem);
            }
            int userPurchaseAlpha = int.Parse(Console.ReadLine());


            if (userPurchaseAlpha == 0)
            {
                userMoney -= 100;
            }
            else if (userPurchaseAlpha == 1)
            {
                userMoney -= 400;
            }
            else if (userPurchaseAlpha == 2)
            {
                userMoney -= 300;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }

            Console.WriteLine("Your current balance is: " + userMoney);
            Console.ReadLine();
        }

        static void BuyMenuPluto()
        {
            Console.WriteLine("What would you like to purchase?");
            List<string> menu = new List<string>();
            string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3" };
            menu.AddRange(cargoItems);
            foreach (string cargoItem in menu)
            {
                Console.WriteLine(cargoItem);
            }
            int userPurchasePluto = int.Parse(Console.ReadLine());


            if (userPurchasePluto == 0)
            {
                userMoney -= 300;
            }
            else if (userPurchasePluto == 1)
            {
                userMoney -= 200;
            }
            else if (userPurchasePluto == 2)
            {
                userMoney -= 700;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }

            Console.WriteLine("Your current balance is: " + userMoney);
            Console.ReadLine();
        }

        static void SellMenuEarth()
        {
            Console.WriteLine("What would you like to sell?");
            List<string> menu = new List<string>();
            string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3" };
            menu.AddRange(cargoItems);
            foreach (string cargoItem in menu)
            {
                Console.WriteLine(cargoItem);
            }
            int userPurchasePluto = int.Parse(Console.ReadLine());


            if (userPurchasePluto == 0)
            {
                userMoney += 300;
            }
            else if (userPurchasePluto == 1)
            {
                userMoney += 200;
            }
            else if (userPurchasePluto == 2)
            {
                userMoney += 700;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }

            Console.WriteLine("Your current balance is: " + userMoney);
            Console.ReadLine();
        }

        static void SellMenuAlpha()
        {
            Console.WriteLine("What would you like to sell?");
            List<string> menu = new List<string>();
            string[] cargoItems = { "Type 0 for Silver $100 Cargo space = 1", "Type 1 for Gold $400 Cargo space = 2",
                "Type 2 for Diamond $300 Cargo space = 3" };
            menu.AddRange(cargoItems);
            foreach (string cargoItem in menu)
            {
                Console.WriteLine(cargoItem);
            }
            int userPurchaseAlpha = int.Parse(Console.ReadLine());


            if (userPurchaseAlpha == 0)
            {
                userMoney += 100;
            }
            else if (userPurchaseAlpha == 1)
            {
                userMoney += 400;
            }
            else if (userPurchaseAlpha == 2)
            {
                userMoney += 300;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }

            Console.WriteLine("Your current balance is: " + userMoney);
            Console.ReadLine();
        }

         static void SellMenuPluto()
        {
            Console.WriteLine("What would you like to sell?");
            List<string> menu = new List<string>();
            string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3" };
            menu.AddRange(cargoItems);
            foreach (string cargoItem in menu)
            {
                Console.WriteLine(cargoItem);
            }
            int userPurchasePluto = int.Parse(Console.ReadLine());


            if (userPurchasePluto == 0)
            {
                userMoney += 300;
            }
            else if (userPurchasePluto == 1)
            {
                userMoney += 200;
            }
            else if (userPurchasePluto == 2)
            {
                userMoney += 700;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }

            Console.WriteLine("Your current balance is: " + userMoney);
            Console.ReadLine();
        }

        static void ShipUp()
        {

        }

        static void Travel()
        {
            Console.WriteLine("Where would you like to travel?");
            Console.WriteLine("Type 1 for Earth, Type 2 for Alpha Centauri or Type 3 for Pluto");
            int planetSelection = int.Parse(Console.ReadLine());
            
            if (planetSelection == 1)
            {
                MainMenuEarth();
            }
            else if (planetSelection == 2)
            {
                MainMenuAlpha();
            }
            else if (planetSelection == 3)
            {
                MainMenuPluto();
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }
           
            
        }

        static void exit()
        {

        }

        
    }
}
