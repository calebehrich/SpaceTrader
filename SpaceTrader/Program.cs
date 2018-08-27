using System;
using System.Collections.Generic;

namespace SpaceTrader
{
    class Program
    {
        static double userMoney = 1000;
        static int silverCargo = 0;
        static int goldCargo = 0;
        static int diamondCargo = 0;
        static int userCargo = 0;
        static double timeTrav = 0;
        static double moneyTotal = 0;        
        static bool validInput = true;
        static int cargoCap = 0;
        static double shipSpeed = 0;
         
        

        static void Main(string[] args)
        {
            // GameStory();
            // GameDirections();
            ShipUp();
            Travel();
           // TODO Find a way to add cargo together and constraint buying and selling based on cargo
        }

        static void GameStory()
        {
            string[] directions = System.IO.File.ReadAllLines(@"c:\users\wwstudent\Source\Repos\SpaceTrader\SpaceTrader\GameStory.txt");
        }  //TODO find out how to use these files on all computers
        static void GameDirections()
        {
            string[] directions = System.IO.File.ReadAllLines(@"c: \users\wwstudent\Source\Repos\SpaceTrader\SpaceTrader\GameDirections.txt");
        }//TODO same

        static void UserStats()
        {
            Console.WriteLine(userCargo);
            Console.WriteLine(timeTrav);
            Console.WriteLine(moneyTotal);
            Console.WriteLine(userMoney);
        }

        static void MainMenuEarth()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Earth! What would you like to do?");
                Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel, Type 4 to view Player stats, Type 5 to Exit");
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
                else if (userSelection == 5)
                {
                    Exit();
                    validInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please select an option.");
                    validInput = false;                   
                }
            } while (!validInput);
          
            
        }

        static void MainMenuAlpha()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Alpha Centauri! What would you like to do?");
                Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel or Type 4 to view Player stats, Type 5 to exit");
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
                else if (userSelection == 5)
                {
                    Exit();
                    validInput = true;
                }
                else
                {
                Console.Clear();
                Console.WriteLine("Invalid input. Please select an option.");
                validInput = false;
                }
            } while (!validInput);
        }

        static void MainMenuPluto()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Pluto! What would you like to do?");
                Console.WriteLine("Type 1 to buy, Type 2 to sell, Type 3 to Travel or Type 4 to view Player stats, Type 5 to exit");
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
                else if (userSelection == 5)
                {
                    Exit();
                    validInput = true;
                }
                else
                {
                Console.Clear();
                Console.WriteLine("Invalid input. Please select an option.");
                validInput = false;
                }
            } while (!validInput);
        }

        static void BuyMenuEarth()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to purchase?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $200 Cargo space = 1", "Type 1 for Gold $300 Cargo space = 2",
                "Type 2 for Diamond $500 Cargo space = 3", "Type 3 to exit to main menu" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                    Console.WriteLine(cargoItem);
                }
                int userPurchaseEarth = int.Parse(Console.ReadLine());

                int purchaseSilver = 200;
                int purchaseGold = 300;
                int purchaseDiamond = 500;
                
                
                if (userPurchaseEarth == 0 && userMoney > purchaseSilver && silverCargo < cargoCap)
                {                    
                    userMoney -= 200;
                    silverCargo += 1;
                }
                else if (userPurchaseEarth == 1 && userMoney > purchaseGold && goldCargo < cargoCap)
                {
                    userMoney -= 300;
                    goldCargo += 2;
                }
                else if (userPurchaseEarth == 2 && userMoney > purchaseDiamond && diamondCargo < cargoCap)
                {                   
                    userMoney -= 500;
                    diamondCargo += 3;
                }
                else if (userPurchaseEarth == 3)
                {
                    MainMenuEarth();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            } while (!validInput);
        }

        static void BuyMenuAlpha()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to purchase?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $100 Cargo space = 1", "Type 1 for Gold $400 Cargo space = 2",
                "Type 2 for Diamond $300 Cargo space = 3", "Type 3 to exit"};
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                Console.WriteLine(cargoItem);
                }
                int userPurchaseAlpha = int.Parse(Console.ReadLine());

                int purchaseSilver = 100;
                int purchaseGold = 400;
                int purchaseDiamond = 300;

                if (userPurchaseAlpha == 0 && userMoney > purchaseSilver && silverCargo < cargoCap)
                {
                    userMoney -= 100;
                    silverCargo += 1;
                }
                else if (userPurchaseAlpha == 1 && userMoney > purchaseGold  && goldCargo < cargoCap)
                {
                    userMoney -= 400;
                    goldCargo += 2;
                }
                else if (userPurchaseAlpha == 2 && userMoney > purchaseDiamond && diamondCargo < cargoCap)
                {
                    userMoney -= 300;
                    diamondCargo += 3;
                }
                else if (userPurchaseAlpha == 3)
                {
                    MainMenuAlpha();
                }
                else
                {
                Console.WriteLine("Invalid input.");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            }while (!validInput);
        }   

        static void BuyMenuPluto()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to purchase?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3", "Type 3 to exit" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                Console.WriteLine(cargoItem);
                }
                int userPurchasePluto = int.Parse(Console.ReadLine());

                int purchaseSilver = 300;
                int purchaseGold = 200;
                int purchaseDiamond = 700;

                if (userPurchasePluto == 0 && userMoney > purchaseSilver && silverCargo < cargoCap)
                {
                    userMoney -= 300;
                    silverCargo += 1;
                }
                else if (userPurchasePluto == 1 && userMoney > purchaseGold && goldCargo < cargoCap)
                {
                    userMoney -= 200;
                    goldCargo += 2;
                }
                else if (userPurchasePluto == 2 && userMoney > purchaseDiamond && diamondCargo < cargoCap)
                {
                    userMoney -= 700;
                    diamondCargo += 3;
                }
                else if (userPurchasePluto == 3)
                {
                    MainMenuPluto();
                }
                else
                {
                Console.WriteLine("Invalid input.");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            } while (!validInput);
        }

        static void SellMenuEarth()
        {
            do
            { 
                Console.WriteLine("What would you like to sell?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3", "Type 3 to exit" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                Console.WriteLine(cargoItem);
                }
                int userPurchasePluto = int.Parse(Console.ReadLine());


                if (userPurchasePluto == 0 && silverCargo > 0)
                {
                    userMoney += 300;
                    silverCargo -= 1;
                }
                else if (userPurchasePluto == 1 && goldCargo > 0)
                {
                    userMoney += 200;
                    goldCargo -= 2;
                }
                else if (userPurchasePluto == 2 && diamondCargo > 0)
                {
                    userMoney += 700;
                    diamondCargo -= 3;
                }
                else if (userPurchasePluto == 3)
                {
                    MainMenuEarth();
                }
                else
                {
                Console.WriteLine("Invalid input. Please select an option");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            } while (!validInput);
        }

        static void SellMenuAlpha()
        {
            do
            { 
                Console.WriteLine("What would you like to sell?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $100 Cargo space = 1", "Type 1 for Gold $400 Cargo space = 2",
                "Type 2 for Diamond $300 Cargo space = 3", "Type 3 to exit" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                Console.WriteLine(cargoItem);
                }
                int userPurchaseAlpha = int.Parse(Console.ReadLine());


                if (userPurchaseAlpha == 0 && silverCargo > 0)
                {
                    userMoney += 100;
                    silverCargo -= 1;
                }
                else if (userPurchaseAlpha == 1 && goldCargo > 0)
                {
                    userMoney += 400;
                    goldCargo -= 2;
                }
                else if (userPurchaseAlpha == 2 && diamondCargo > 0)
                {
                    userMoney += 300;
                    diamondCargo -= 3;
                }
                else if (userPurchaseAlpha == 3)
                {
                    MainMenuAlpha();
                }
                else
                {
                Console.WriteLine("Invalid input. Please select an option");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            } while (!validInput);
        }

         static void SellMenuPluto()
        {
            do
            { 
                Console.WriteLine("What would you like to sell?");
                List<string> menu = new List<string>();
                string[] cargoItems = { "Type 0 for Silver $300 Cargo space = 1", "Type 1 for Gold $200 Cargo space = 2",
                "Type 2 for Diamond $700 Cargo space = 3", "Type 3 to exit" };
                menu.AddRange(cargoItems);
                foreach (string cargoItem in menu)
                {
                Console.WriteLine(cargoItem);
                }
                int userPurchasePluto = int.Parse(Console.ReadLine());


                if (userPurchasePluto == 0 && silverCargo > 0)
                {
                    userMoney += 300;
                    silverCargo -= 1;
                }
                else if (userPurchasePluto == 1 && goldCargo > 0)
                {
                    userMoney += 200;
                    goldCargo -= 2;
                }
                else if (userPurchasePluto == 2 && diamondCargo > 0)
                {
                    userMoney += 700;
                    diamondCargo -= 3;
                }
                else if (userPurchasePluto == 3)
                {
                    MainMenuPluto();
                }
                else
                {
                Console.WriteLine("Invalid input. Please select an option");
                }

                Console.WriteLine("Your current balance is: " + userMoney);
                Console.WriteLine("Your current silver cargo is: " + silverCargo);
                Console.WriteLine("Your current gold cargo is: " + goldCargo);
                Console.WriteLine("Your current diamond cargo is: " + diamondCargo);
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                validInput = false;
            } while (!validInput);
        }

        static void ShipUp()
        {
            do
            {
                Console.WriteLine("Welcome to the Ship Garage. Which ship would you like?");
                Console.WriteLine("Type 1 for Basic $0 Max Speed: 3 Cargo Max: 5, Type 2 for Intermediate $2000  Max Speed: 6 Cargo Max: 10," +
                    " Type 3 for Advanced $5000 Max Speed: 9 Cargo Max: 15 or Type 4 to Exit");
                int shipSelection = int.Parse(Console.ReadLine());

                if (shipSelection == 1)
                {
                    BasicShip();
                }
                else if (shipSelection == 2)
                {
                    InterShip();
                }
                else if (shipSelection == 3)
                {
                    AdvShip();
                }
                else if (shipSelection == 4)
                {
                    MainMenuEarth();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select an option.");
                }
            } while (!validInput);
        }

        static void BasicShip()
        {
            double shipSpeed = (Math.Pow(3, 10.0 / 3) + Math.Pow(7, -11.0 / 3));
            cargoCap = 5;
        }

        static void InterShip()
        {
            userMoney -= 2000;
            Console.WriteLine("Congratulations!! You purchased the Intermediate Ship!");
            double shipSpeed = (Math.Pow(6, 10.0 / 3) + Math.Pow(4, -11.0 / 3));
            cargoCap = 10;
        }

        static void AdvShip()
        {
            userMoney -= 5000;
            Console.WriteLine("Congratulations!! You purchased the Advanced Ship!");
            double shipSpeed = (Math.Pow(9, 10.0 / 3) + Math.Pow(1, -11.0 / 3));
            cargoCap = 15;
        }

        static void Travel()
        {
            Console.WriteLine("Where would you like to travel?");
            Console.WriteLine("Type 1 for Earth, Type 2 for Alpha Centauri or Type 3 for Pluto");
            int planetSelection = int.Parse(Console.ReadLine());
            
            if (planetSelection == 1)
            {
                Console.Clear();
                MainMenuEarth();
            }
            else if (planetSelection == 2)
            {
                Console.Clear();
                MainMenuAlpha();
            }
            else if (planetSelection == 3)
            {
                Console.Clear();
                MainMenuPluto();
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option");
            }
           
            
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER");
            UserStats();
            Console.ReadLine();
        }
 
    }
}
