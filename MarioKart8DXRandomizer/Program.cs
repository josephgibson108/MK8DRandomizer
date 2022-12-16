using System;
using System.Collections.Generic;

namespace MarioKart8DXRandomizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // array of characters
            // there are 42 characters
            string[] characters = new string[41] { "Mario", "Luigi", "Peach", "Daisy", "Rosalina", "Tanooki Mario", "Cat Peach", "Yoshi", "Toad", 
                                                    "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "King Boo", "Baby Mario", "Baby Luigi", "Baby Peach", 
                                                    "Baby Daisy", "Baby Rosalina", "Metal Mario/Gold Mario", "Pink Gold Peach", "Wario", "Waluigi", 
                                                    "Donkey Kong", "Bowser", "Dry Bones", "Bowser Jr.", "Dry Bowser", "Lemmy", "Larry", "Wendy", "Ludwig", 
                                                    "Iggy", "Roy", "Morton", "Inkling Girl", "Inkling Boy", "Link", "Male Villager", "Female Villager", 
                                                    "Isabelle" };
            // there are 16 small characters
            string[] smallCharacters = new string[16] { "Toad", "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "Baby Mario", "Baby Luigi", "Baby Peach", 
                                                        "Baby Daisy", "Baby Rosalina", "Dry Bones", "Bowser Jr.", "Lemmy", "Larry", "Wendy", "Isabelle" };
            // there are 15 medium characters
            string[] mediumCharacters = new string[15] { "Cat Peach", "Inkling Girl", "Female Villager", "Peach", "Daisy", "Yoshi", "Tanooki Mario", 
                                                        "Inkling Boy", "Male Villager", "Mario", "Ludwig", "Luigi", "Iggy", "Metal Mario/Gold Mario", 
                                                        "Pink Gold Peach" };
            // there are 10 heavy characters
            string[] heavyCharacters = new string[10] { "Rosalina", "King Boo", "Link", "Waluigi", "Donkey Kong", "Roy", "Wario", "Dry Bowser", "Bowser", 
                                                        "Morton" };
            // there are 41 vehicles
            string[] allVehicles = new string[41] { "Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special", 
                                                    "Tri-Speeder", "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker", "Sports Coupe",
                                                    "Gold Standard", "GLA", "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon", "Tanooki Kart", 
                                                    "B Dasher", "Streetle", "P-Wing", "Koopa CLown", "Standard Bike", "The Duke", "Flame Runner", 
                                                    "Varmint", "Mr. Scooty", "Master Cycle Zero", "City Tripper", "Comet", "Sport Bike", "Jet Bike", 
                                                    "Yoshi Bike", "Master Cycle", "Standard ATV", "Wild Wiggler", "Teddy Buggy", "Bone Rider", "Splat Buggy", "Inkstriker"};
            // there are 23 karts
            string[] karts = new string[23] { "Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special", "Tri-Speeder", 
                                              "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker", "Sports Coupe", "Gold Standard", "GLA", 
                                              "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon", "Tanooki Kart", "B Dasher", "Streetle", "P-Wing", "Koopa CLown" };
            // there are 12 bikes
            string[] bikes = new string[12] { "Standard Bike", "The Duke", "Flame Runner", "Varmint", "Mr. Scooty", "Master Cycle Zero", 
                                              "City Tripper", "Comet", "Sport Bike", "Jet Bike", "Yoshi Bike", "Master Cycle" };
            // there are 6 atvs
            string[] atvs = new string[6] { "Standard ATV", "Wild Wiggler", "Teddy Buggy", "Bone Rider", "Splat Buggy", "Inkstriker" };
            // there are 22 wheels
            string[] wheels = new string[22] { "Standard", "Blue Standard", "Monster", "Hot Monster", "Roller", "Azure Roller", "Slim", "Crimson Slim", 
                                                "Slick", "Cyber Slick", "Metal", "Button", "Off-Road", "Retro Off-Road", "Sponge", "Wood", "Cushion", 
                                                "Gold Tires", "GLA Tires", "Triforce Tires", "Ancient Tires", "Leaf Tires" };
            // there are 15 gliders
            string[] gliders = new string[15] { "Super Glider", "Cloud Glider", "Wario Wing", "Waddle Wing", "Peach Parasol", "Parachute", "Parafoil", 
                                                "Flower Glider", "Bowser Kite", "Plane Glider", "MKTV Parafoil", "Gold Glider", "Hylian Kite", "Paraglider", 
                                                "Paper Glider" };

            Console.WriteLine("**********");
            Console.WriteLine("Welcome to Mario Kart!");
            Console.WriteLine("**********");
            Console.WriteLine("");
            int numOfPlayers = -1;
            string input = "";
            bool success = false;
            // while (numOfPlayers < 1 || numOfPlayers > 4
            while (numOfPlayers < 1 || numOfPlayers > 4)
            { 
                Console.WriteLine("How many people are playing?");
                input = Console.ReadLine();

                // make sure the input is an int
                success = int.TryParse(input, out int result);
                if (success == false)
                {
                    Console.WriteLine("Make sure you enter an int!");
                }
                else
                {
                    numOfPlayers = int.Parse(input);

                    if (numOfPlayers < 1 || numOfPlayers > 4)
                    {
                        Console.WriteLine("The number of players must be between 1 and 4!");
                    }
                }
            }

            // create a List to hold the players
            List<Player> players = new List<Player>();

            // create player objects equal to the number of players
            for (int i = 0; i < numOfPlayers; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Player " + (i + 1) + "'s name: ");
                string playerName = Console.ReadLine();

                Player player = new Player();

                player.Name = playerName;

                players.Add(player);
            }

            string yesOrNo = "";
            Console.WriteLine("");
            Console.WriteLine("***");
            Console.WriteLine("Do you want everything randomized (Y), or only specific things(N)?");

            while (yesOrNo != "YES" || yesOrNo != "Y" || yesOrNo != "NO" || yesOrNo != "N")
            {
                yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();

                // loop through each player object and randomize their combinations
                if (yesOrNo == "YES" || yesOrNo == "Y")
                {
                    foreach (Player player in players)
                    {
                        Random rnd = new Random();

                        // character
                        int index = rnd.Next(characters.Length);
                        player.Character = characters[index];

                        // vehicle
                        index = rnd.Next(allVehicles.Length);
                        player.Vehicle = allVehicles[index];

                        // wheels
                        index = rnd.Next(wheels.Length);
                        player.Wheels = wheels[index];

                        // glider 
                        index = rnd.Next(gliders.Length);
                        player.Glider = gliders[index];

                        Console.WriteLine("");
                        Console.WriteLine($"*** {player.Name.ToUpper()}'S COMBO ***");
                        Console.WriteLine(player.Character);
                        Console.WriteLine(player.Vehicle);
                        Console.WriteLine(player.Wheels);
                        Console.WriteLine(player.Glider);
                        Console.WriteLine("");

                    }
                    Console.WriteLine("");
                    Console.WriteLine("**********");
                    Console.WriteLine("Good luck!");
                    Console.WriteLine("**********");
                    break;
                }
                // ask for restrictions
                else if (yesOrNo == "NO" || yesOrNo == "N")
                {
                    foreach (Player player in players)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{player.Name}, what do you NOT want to be included in the randomizer?");
                        Console.WriteLine("");
                        Console.WriteLine("Enter your choices separated by a comma");
                        Console.WriteLine("For example: medium characters, karts, atvs");
                        Console.WriteLine("");
                        Console.WriteLine("Your choices are:");
                        Console.WriteLine("small characters, medium characters, large characters, karts, bikes, atvs");
                        Console.WriteLine("");

                        string restrictionsInput = Console.ReadLine().ToLower();

                        // delineate the string
                        string[] restrictions = restrictionsInput.Split(", ");
                        // character restrictions
                        // no small or medium characters
                        
                        if (Array.Exists(restrictions, element => element == "small characters")
                            && Array.Exists(restrictions, element => element == "medium characters"))
                        {
                            Random rnd = new Random();

                            int index = rnd.Next(heavyCharacters.Length);
                            player.Character = heavyCharacters[index];
                        }
                        // no medium or heavy characters
                        else if (Array.Exists(restrictions, element => element == "medium characters")
                            && Array.Exists(restrictions, element => element == "large characters"))
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(smallCharacters.Length);
                            player.Character = smallCharacters[index];
                        }
                        // no small or heavy characters
                        else if (Array.Exists(restrictions, element => element == "small characters")
                            && Array.Exists(restrictions, element => element == "large characters"))
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(mediumCharacters.Length);
                            player.Character = mediumCharacters[index];
                        }
                        // no small characters
                        // else if (Array.IndexOf(restrictions, "small characters") > -1)
                        else if(Array.Exists(restrictions, element => element == "small characters"))
                        {
                            string[] mediumAndLargeCharacters = new string[25] {"Cat Peach", "Inkling Girl", "Female Villager", "Peach", "Daisy", "Yoshi", "Tanooki Mario",
                                                        "Inkling Boy", "Male Villager", "Mario", "Ludwig", "Luigi", "Iggy", "Metal Mario/Gold Mario",
                                                        "Pink Gold Peach", "Rosalina", "King Boo", "Link", "Waluigi", "Donkey Kong", "Roy", "Wario", 
                                                        "Dry Bowser", "Bowser", "Morton" };
                            Random rnd = new Random();
                            int index = rnd.Next(mediumAndLargeCharacters.Length);
                            player.Character = mediumAndLargeCharacters[index];
                        }
                        // no medium characters
                        else if (Array.Exists(restrictions, element => element == "medium characters"))
                        {
                            string[] smallAndLargeCharacters = new string[26] {"Toad", "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "Baby Mario", "Baby Luigi", "Baby Peach",
                                                        "Baby Daisy", "Baby Rosalina", "Dry Bones", "Bowser Jr.", "Lemmy", "Larry", "Wendy", "Isabelle",
                                                        "Rosalina", "King Boo", "Link", "Waluigi", "Donkey Kong", "Roy", "Wario", "Dry Bowser", "Bowser",
                                                        "Morton"};
                            Random rnd = new Random();
                            int index = rnd.Next(smallAndLargeCharacters.Length);
                            player.Character = smallAndLargeCharacters[index];
                        }
                        // no large characters
                        else if (Array.Exists(restrictions, element => element == "large characters"))
                        {
                            string[] smallAndMediumCharacters = new string[31] { "Toad", "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "Baby Mario",
                                                        "Baby Luigi", "Baby Peach", "Baby Daisy", "Baby Rosalina", "Dry Bones", "Bowser Jr.", "Lemmy",
                                                        "Larry", "Wendy", "Isabelle", "Cat Peach", "Inkling Girl", "Female Villager", "Peach", "Daisy", 
                                                        "Yoshi", "Tanooki Mario", "Inkling Boy", "Male Villager", "Mario", "Ludwig", "Luigi", "Iggy", 
                                                        "Metal Mario/Gold Mario", "Pink Gold Peach"};
                            Random rnd = new Random();
                            int index = rnd.Next(smallAndMediumCharacters.Length);
                            player.Character = smallAndMediumCharacters[index];
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No characters detected. Randomizing all characters.");
                            Random rnd = new Random();
                            int index = rnd.Next(characters.Length);
                            player.Character = characters[index];
                        }

                        // if statements for karts, bikes, atvs
                        // no karts or bikes
                        if (Array.Exists(restrictions, element => element == "karts")
                            && Array.Exists(restrictions, element => element == "bikes"))
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(atvs.Length);
                            player.Vehicle = atvs[index];
                        }
                        // no karts or atvs
                        else if (Array.Exists(restrictions, element => element == "karts")
                            && Array.Exists(restrictions, element => element == "atvs"))
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(bikes.Length);
                            player.Vehicle = bikes[index];
                        }
                        // nok bikes or atvs
                        else if (Array.Exists(restrictions, element => element == "bikes")
                            && Array.Exists(restrictions, element => element == "atvs"))
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(karts.Length);
                            player.Vehicle = karts[index];
                        }
                        // no karts
                        else if (Array.Exists(restrictions, element => element == "karts"))
                        {
                            Random rnd = new Random();
                            string[] bikesAndAtvs = new string[] { "Standard Bike", "The Duke", "Flame Runner", "Varmint", "Mr. Scooty", "Master Cycle Zero", 
                                "City Tripper", "Comet", "Sport Bike", "Jet Bike", "Yoshi Bike", "Master Cycle", "Standard ATV", "Wild Wiggler", 
                                "Teddy Buggy", "Bone Rider", "Splat Buggy", "Inkstriker" };
                            int index = rnd.Next(bikesAndAtvs.Length);
                            player.Vehicle = bikesAndAtvs[index];
                        }
                        // no bikes
                        else if (Array.Exists(restrictions, element => element == "bikes"))
                        {
                            Random rnd = new Random();
                            string[] kartsAndAtvs = new string[] {"Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special", "Tri-Speeder",
                                              "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker", "Sports Coupe", "Gold Standard", "GLA",
                                              "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon", "Tanooki Kart", "B Dasher", "Streetle", "P-Wing", "Koopa CLown",
                                               "Standard ATV", "Wild Wiggler", "Teddy Buggy", "Bone Rider", "Splat Buggy", "Inkstriker" };
                            int index = rnd.Next(kartsAndAtvs.Length);
                            player.Vehicle = kartsAndAtvs[index];
                        // no atvs
                        }
                        else if (Array.Exists(restrictions, element => element == "atvs"))
                        {
                            Random rnd = new Random();
                            string[] kartsAndBikes = new string[] { "Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special", "Tri-Speeder",
                                              "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker", "Sports Coupe", "Gold Standard", "GLA",
                                              "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon", "Tanooki Kart", "B Dasher", "Streetle", "P-Wing", "Koopa CLown",
                                              "Standard Bike", "The Duke", "Flame Runner", "Varmint", "Mr. Scooty", "Master Cycle Zero",
                                              "City Tripper", "Comet", "Sport Bike", "Jet Bike", "Yoshi Bike", "Master Cycle"};
                            int index = rnd.Next(kartsAndBikes.Length);
                            player.Vehicle = kartsAndBikes[index];
                        }
                        // this should be what happens if the player doesn't select anything, or doesn't select something compatible
                        // I'm gonna need to put this as the last else for characters and vehicles, maybe specify "you need at least one type of character/vehicle"
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No vehicles detected. Randomizing all vechicles."); 
                            Random rnd = new Random();
                            int index = rnd.Next(allVehicles.Length);
                            player.Vehicle = allVehicles[index];
                        }

                        Random rnd2 = new Random();
                        // wheels
                        int index2 = rnd2.Next(wheels.Length);
                        player.Wheels = wheels[index2];

                        // glider 
                        index2 = rnd2.Next(gliders.Length);
                        player.Glider = gliders[index2];
                    }

                    foreach (Player player in players)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"*** {player.Name.ToUpper()}'S COMBO ***");
                        Console.WriteLine(player.Character);
                        Console.WriteLine(player.Vehicle);
                        Console.WriteLine(player.Wheels);
                        Console.WriteLine(player.Glider);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("**********");
                    Console.WriteLine("Good luck!");
                    Console.WriteLine("**********");
                    break;
                }
                else
                {
                    Console.WriteLine("*");
                    Console.WriteLine("Please enter Y or N");
                    Console.WriteLine("No restrictions (Y)");
                    Console.WriteLine("Restrictions (N)");
                    Console.WriteLine("*");
                }
            }
        }
    }
}
