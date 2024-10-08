namespace LearnCSharp.Excercises
{
    public class GuidedProjects
    {
        public static void AnimalSpecies(bool execute = false)
        {
            if (!execute)
                return;

            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // TODO: Convert the if-elseif-else construct to a switch statement

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;
                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;
                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;
                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            // display the top-level menu options

            do
            {

                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // Console.WriteLine($"You selected menu option {menuSelection}.");
                // Console.WriteLine("Press the Enter key to continue");

                // pause code execution
                // readResult = Console.ReadLine();
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                            }
                        }
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        string anotherPet = "y";
                        int petCount = 0;

                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {maxPets - petCount} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets)
                        {
                            bool validEntry = false;

                            do
                            {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();

                                    if (animalSpecies != "dog" && animalSpecies != "cat")
                                    {
                                        validEntry = false;
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            animalID = string.Concat(animalSpecies.AsSpan(0, 1), (petCount + 1).ToString());

                            do
                            {
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalAge = readResult;

                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out int petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();

                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (animalPhysicalDescription == "");

                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();

                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (animalPersonalityDescription == "");

                            do
                            {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalNickname = readResult.ToLower();

                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }

                                }
                            } while (animalNickname == "");

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            petCount++;

                            if (petCount < maxPets)
                            {
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");

                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.ToLower();
                                    }

                                } while (anotherPet != "y" && anotherPet != "n");
                            }
                        }

                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    default:
                        break;
                }

            } while (menuSelection != "exit");

        }

        public static void JaggedArray(bool execute = false)
        {
            if (!execute)
                return;

            string[][] jaggedArray =
            [
                ["one1", "two1", "three1", "four1", "five1", "six1"],
                    ["one2", "two2", "three2", "four2", "five2", "six2"],
                    ["one3", "two3", "three3", "four3", "five3", "six3"],
                    ["one4", "two4", "three4", "four4", "five4", "six4"],
                    ["one5", "two5", "three5", "four5", "five5", "six5"],
                    ["one6", "two6", "three6", "four6", "five6", "six6"],
                    ["one7", "two7", "three7", "four7", "five7", "six7"],
                    ["one8", "two8", "three8", "four8", "five8", "six8"]
            ];

            foreach (string[] array in jaggedArray)
            {
                foreach (string value in array)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }

        }

        public static void AnimalSpeciesChallenge(bool execute = false)
        {
            if (!execute)
                return;

            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            int petCount = 0;
            string anotherPet = "y";
            bool validEntry = false;
            int petAge = 0;

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";

                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            // display the top-level menu options
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                    // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
                    //  use a conditional statement below that only processes the valid entry values, so the do statement 
                    //  is not required here. 
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        //
                        // The ourAnimals array contains
                        //    1. the species (cat or dog). a required field
                        //    2. the ID number - for example C17
                        //    3. the pet's age. can be blank at initial entry.
                        //    4. the pet's nickname. can be blank.
                        //    5. a description of the pet's physical appearance. can be blank.
                        //    6. a description of the pet's personality. can be blank.

                        anotherPet = "y";
                        petCount = 0;
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets)
                        {
                            // get species (cat or dog) - string animalSpecies is a required field 
                            do
                            {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();
                                    if (animalSpecies != "dog" && animalSpecies != "cat")
                                    {
                                        //Console.WriteLine($"You entered: {animalSpecies}.");
                                        validEntry = false;
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                            // get the pet's age. can be ? at initial entry.
                            do
                            {
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);


                            // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);


                            // get a description of the pet's personality - animalPersonalityDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);


                            // get the pet's nickname. animalNickname can be blank.
                            do
                            {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalNickname = readResult.ToLower();
                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (validEntry == false);

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                            petCount = petCount + 1;

                            // check maxPet limit
                            if (petCount < maxPets)
                            {
                                // another pet?
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.ToLower();
                                    }

                                } while (anotherPet != "y" && anotherPet != "n");
                            }
                            //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
                        }

                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalAge = readResult;
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 2] = "Age: " + animalAge.ToString();
                            }

                            if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalPhysicalDescription = readResult.ToLower();
                                        if (animalPhysicalDescription == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }

                                    }
                                } while (validEntry == false);

                                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            }
                        }
                        Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        // Ensure animal nicknames and personality descriptions are complete
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalNickname = readResult;
                                        if (animalNickname == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }

                                    }

                                } while (validEntry == false);

                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                            }

                            if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
                            {
                                do
                                {
                                    //"Enter a description of the pet's personality (likes or dislikes, tricks, energy level"
                                    Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalPersonalityDescription = readResult.ToLower();
                                        if (animalPersonalityDescription == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);

                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            }
                        }
                        Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        // Edit an animal’s age");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        // Edit an animal’s personality description");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        // Display all cats with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        // Display all dogs with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");

        }

        public static void AnimalSpeciesChallenge2(bool execute = false)
        {
            if (!execute)
                return;

            // #1 the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            string suggestedDonation = "";

            // #2 variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            decimal decimalDonation = 0.00m;

            // #3 array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 7];

            // #4 create sample data ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";

                        suggestedDonation = "85.00";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";

                        suggestedDonation = "49.99";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";

                        suggestedDonation = "40.00";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = ".";
                        animalNickname = "lion";

                        suggestedDonation = "";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";

                        suggestedDonation = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if (!decimal.TryParse(suggestedDonation, out decimalDonation))
                {

                    decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00

                }

                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";

            }

            // #5 display the top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // list all pet info
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 7; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Display all dogs with a specified characteristic
                        string dogCharacteristic = "";

                        while (dogCharacteristic == "")
                        {
                            // have the user enter physical characteristics to search for
                            Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                dogCharacteristic = readResult.ToLower().Trim();
                            }
                        }

                        bool noMatchesDog = true;
                        string dogDescription = "";

                        // #6 loop through the ourAnimals array to search for matching animals
                        for (int i = 0; i < maxPets; i++)
                        {
                            bool dogMatch = true;

                            if (ourAnimals[i, 1].Contains("dog"))
                            {
                                if (dogMatch == true)
                                {
                                    // #7 Search combined descriptions and report results
                                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                                    if (dogDescription.Contains(dogCharacteristic))
                                    {
                                        Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                        Console.WriteLine(dogDescription);
                                        noMatchesDog = false;
                                    }
                                }
                            }
                        }

                        if (noMatchesDog)
                        {
                            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);

                        }

                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");
        }

        public static void AnimalSpeciesChallenge3(bool execute = false)
        {
            if (!execute)
                return;

            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            decimal decimalDonation = 0.00m;

            // array used to store runtime data
            string[,] ourAnimals = new string[maxPets, 7];

            // sample data ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        suggestedDonation = "85.00";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";
                        suggestedDonation = "49.99";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";
                        suggestedDonation = "40.00";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "lion";
                        suggestedDonation = "";

                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if (!decimal.TryParse(suggestedDonation, out decimalDonation))
                {
                    decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
                }
                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            }

            // top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // list all pet info
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();

                                for (int j = 0; j < 7; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }

                        Console.WriteLine("\r\nPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // #1 Display all dogs with a multiple search characteristics

                        string dogCharacteristics = "";

                        while (dogCharacteristics == "")
                        {
                            // #2 have user enter multiple comma separated characteristics to search for
                            Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                dogCharacteristics = readResult.ToLower();
                                Console.WriteLine();
                            }
                        }

                        string[] dogSearches = dogCharacteristics.Split(",");
                        // trim leading and trailing spaces from each search term
                        for (int i = 0; i < dogSearches.Length; i++)
                        {
                            dogSearches[i] = dogSearches[i].Trim();
                        }

                        Array.Sort(dogSearches);
                        // #4 update to "rotating" animation with countdown
                        string[] searchingIcons = { " |", " /", "--", " \\", " *" };

                        bool matchesAnyDog = false;
                        string dogDescription = "";

                        // loops through the ourAnimals array to search for matching animals
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 1].Contains("dog"))
                            {

                                // Search combined descriptions and report results
                                dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                                bool matchesCurrentDog = false;

                                foreach (string term in dogSearches)
                                {
                                    // only search if there is a term to search for
                                    if (term != null && term.Trim() != "")
                                    {
                                        for (int j = 2; j > -1; j--)
                                        {
                                            // #5 update "searching" message to show countdown
                                            foreach (string icon in searchingIcons)
                                            {
                                                Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
                                                Thread.Sleep(100);
                                            }

                                            Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                                        }

                                        // #3a iterate submitted characteristic terms and search description for each term
                                        if (dogDescription.Contains(" " + term.Trim() + " "))
                                        {
                                            // #3b update message to reflect current search term match 

                                            Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

                                            matchesCurrentDog = true;
                                            matchesAnyDog = true;
                                        }
                                    }
                                }

                                // #3d if the current dog is match, display the dog's info
                                if (matchesCurrentDog)
                                {
                                    Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                                }
                            }
                        }

                        if (!matchesAnyDog)
                        {
                            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
                        }

                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    default:
                        break;
                }
            }
            while (menuSelection != "exit");
        }
    }
}