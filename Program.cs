using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {



        static void Main(string[] args)
        {
            List<string> characters = new List<string> { "Darth Vader", "Yoda", "Luke Skywalker", "Princess Leia", "Jabba the Hutt", "Obi-Wan Kenobi", "Boba Fett", "Han Solo", "Emperor Palpatine", "Darth Maul", "Jar Jar Binks", "R2-D2", "C-3PO", "Lando Calrissian", "Qui-Gon Jinn", "Mace Windu", "Jango Fett", "Admiral Ackbar", "Greedo", "Chewbacca" };
            List<string> homeworld = new List<string> { "Tatooine", " no one knows", "Polis Massa", "Polis Massa", "Nal Hutta", "Stewjon", "Kamino", "Corellia", "Naboo", "Iridonia", "Naboo", "data unknown: Memory Wiped", "Created on Tatooine", "Socorro", "Coruscant", "Haruun Kal", "Concord", "Mon Cala", "Rodia", "Kashyyyk" };
            List<string> weapon = new List<string> { "Force Choke!", "Confusing backwards statements", "Peace talks", "Sassy-ness", "a Rancor pit", "Wisdom", "a Flamethrower", "a lot of Blaster with a hint of sarcasm", "Force Lightning", "a Double Bladed Death", "Dumb Luck", "Snarky Beeps and Boops", "Proper Syntax", "Sabacc cards", "Summoning the combined power of Zeus,Ra's Al Ghul and a jedi together", "Getting in every movie in hollywood", "a Jet Pack and Blaster", "Figuring out when its a trap!", "Apparently shooting first", "Pulling roughly on chess players arms" };
            List<string> age = new List<string> {"45","900","23","23","600","58","27","29","65","21","14","3 cycles","1 cycle","42","49","51","29","234","17","123" };
            string response = "y";

            Console.WriteLine("Welcome to the Galaxy!");

            while (response == "y")
            {
                int count = characters.Count;
                Console.WriteLine("Would you like to learn about a character or add a new character? (add or learn) ");
                string addlearn = ValidateAddCharacter();
                if (addlearn == "learn")
                {
                    Console.WriteLine($"Which character would you like to learn more about? (enter a number 1-{count}):");
                    int number = GetValidNumber(count);

                    for (int i = 0; i < characters.Count; i++)
                    {


                        if (i == number - 1)
                        {
                            Console.WriteLine($"Character {number} is {characters[i]} ");
                            Console.WriteLine($"What would you like to know about {characters[i]}? (Enter homeworld or weapon or age)");
                            string choice = Console.ReadLine();

                             
                            try
                            {
                                if (choice == "homeworld")
                                {
                                    Console.WriteLine($"{characters[i]} is from {homeworld[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes: ");

                                    string selection = Console.ReadLine();
                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{characters[i]}'s favorite weapon is {weapon[i]}");
                                        Console.WriteLine("Would you like to know more? Enter Yes:");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{characters[i]}'s age is actually {age[i]}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }
                                }
                                else if (choice == "weapon")
                                {
                                    Console.WriteLine($"{characters[i]}'s favorite weapon is {weapon[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes or no: ");
                                    string selection = Console.ReadLine();

                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{characters[i]} is from {homeworld[i]} ");
                                        Console.WriteLine("would you like to know more? Enter yes: ");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{characters[i]}'s age is actually {age[i]} ");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }
                                }
                                else if (choice == "weapon")
                                {
                                    Console.WriteLine($"{characters[i]}'s age is actually {age[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes or no: ");
                                    string selection = Console.ReadLine();

                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{characters[i]} is from {homeworld[i]}");
                                        Console.WriteLine("Would you like to know more? Enter yes: ");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{characters[i]}'s age is actually {age[i]}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }
                                }
                                else
                                {
                                    throw new Exception("Invalid input, please input homeworld or weapon!");
                                }
                            }
                            catch(Exception e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            Console.WriteLine("Do you want to start again? (y or no) ");
                            response = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    string input;
                    Console.WriteLine("please enter a characters name: ");
                    characters.Add(input = ValidateNewCharacter("Please enter a proper name:"));

                    Console.WriteLine("Please enter a characters homeworld: ");
                    homeworld.Add(input = ValidateNewCharacter("Please enter a proper homeworld: "));

                    Console.WriteLine("Please enter a characters weapon: ");
                    weapon.Add(input = ValidateNewCharacter("Please enter a weapon: "));

                    Console.WriteLine("Please enter a characters age: ");
                    age.Add(input = ValidateNewCharacter("Please enter an actual age: "));

                    Console.WriteLine("Character has been added! Thank you!");
                }
            }
        }
        public static int UserNumber(int number, int count)
        {
            if (number > count || number < 1)
            {
                throw new Exception($"Number must be between 1 and {count}");
            }
            else
            {
                return number;
            }
        }

        public static int GetValidNumber(int count)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                UserNumber(number, count);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number 1-20");
                return GetValidNumber(count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return GetValidNumber(count);
            }
        }
        public static string ValidateAddCharacter()
        {
            string word = Console.ReadLine();
            if(word == "add")
            {
                return word;
            }
            else if(word == "learn")
            {
                return word;
            }
            else if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Type add or learn: ");
                return ValidateAddCharacter();
            }
            else
            {
                Console.WriteLine("Type add or learn: ");
                return ValidateAddCharacter();
            }
        }
        public static string ValidateNewCharacter(string message)
        {
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine(message);
                return ValidateNewCharacter(message);
            }
            else
            {
                return word;
            }
        }
    }
}
