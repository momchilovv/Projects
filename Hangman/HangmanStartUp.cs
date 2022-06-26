using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TextReader reader = new StreamReader("Statistics.txt");

        string gamesPlayedString = reader.ReadLine();
        string gamesWonString = reader.ReadLine();

        double gamesPlayed = double.Parse(gamesPlayedString);
        double gamesWon = double.Parse(gamesWonString);

        reader.Close();

        List<char> guessedLetters = new List<char>();

        List<string> countries = new List<string>()
        {
            "Austria", "Bulgaria", "Estonia", "Germany", "Ukraine", "Spain", "Italy", "France",
            "Russia", "Greece", "Ireland", "Belgium"
        };
        List<string> sports = new List<string>()
        {
            "Football", "Volleyball", "Rugby", "Curling", "Karate", "Tennis", "Cycling", "Basketball",
            "Golf", "Hockey", "Wrestling"
        };
        List<string> carBrands = new List<string>()
        {
            "BMW", "Audi", "Mercedes", "Dodge", "Nissan", "Jeep", "Kia", "Honda", "Porsche", "Toyota",
            "Tesla", "Lexus", "Volkswagen", "Subaru", "Hyundai"
        };
        List<string> animals = new List<string>()
        {
            "Bear", "Cat", "Dog", "Parrot", "Snake", "Fox", "Monkey", "Lion", "Wolf", "Tiger", "Shark",
            "Alligator", "Cheetah", "Deer", "Elephant", "Rabbit", "Jaguar"
        };

        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>()
        {
            { "Country", countries },
            { "Sport", sports },
            { "Car brand", carBrands },
            { "Animal", animals }
        };

        Random random = new Random();

        int index = random.Next(words.Count);

        string type = words.Keys.ElementAt(index);
        string word = null;

        switch (type)
        {
            case "Country":
                word = countries.ElementAt(random.Next(countries.Count));
                break;
            case "Sport":
                word = sports.ElementAt(random.Next(sports.Count));
                break;
            case "Car brand":
                word = carBrands.ElementAt(random.Next(carBrands.Count));
                break;
            case "Animal":
                word = animals.ElementAt(random.Next(animals.Count));
                break;
        }

        Console.WriteLine("Welcome to HANGMAN v0.0.3!");
        Console.WriteLine($"Your word is {type} related and is {word.Length} characters long.");
        Console.WriteLine("The first letter will always be capital!");
        Console.WriteLine($"Games Played: {gamesPlayed} | Games Won: {gamesWon} | Games Lost: {gamesPlayed - gamesWon} | Win Rate: {(gamesWon / gamesPlayed) * 100:f2}%");
        Console.WriteLine("To stop the game, please write \"Quit\"");

        string currentWord = null;

        Console.Write("Word: ");
        for (int i = 0; i < word.Length; i++)
        {
            currentWord += "_";
        }
        foreach (var letter in currentWord)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        int counter = 0;
        Console.Write("Please make your guess: ");
        string input = Console.ReadLine();

        while (input != "Quit")
        {
            if (string.IsNullOrWhiteSpace(input) || input.StartsWith(" ") || input.Contains(" "))
            {
                Console.WriteLine("Your guess is not in the correct format!");
            }
            if (input.Length == 1 && input != " ")
            {
                if (guessedLetters.Contains(char.Parse(input)))
                {
                    Console.WriteLine($"You already made a guess with the letter \"{input}\"!");
                    Console.Write($"Please try again with another letter: ");
                    input = Console.ReadLine();
                    continue;
                }
                guessedLetters.Add(char.Parse(input));
                if (word.Contains(input))
                {
                    StringBuilder stringBuilder = new StringBuilder(currentWord);

                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (word[i] == char.Parse(input))
                        {
                            stringBuilder[i] = char.Parse(input);
                            currentWord = stringBuilder.ToString();
                        }
                    }
                    if (currentWord != word)
                    {
                        foreach (var letter in currentWord)
                        {
                            Console.Write($"{letter} ");
                        }
                        Console.WriteLine();
                    }

                    if (currentWord == word)
                    {
                        TextWriter writer = new StreamWriter("Statistics.txt");

                        writer.WriteLine(gamesPlayed + 1);
                        writer.WriteLine(gamesWon + 1);

                        writer.Close();

                        if (counter == 1)
                        {
                            Console.WriteLine($"Congratulations! You guessed the word \"{word}\" with {counter} mistake!");
                        }
                        else if (counter > 1)
                        {
                            Console.WriteLine($"Congratulations! You guessed the word \"{word}\" with {counter} mistakes!");
                        }
                        else
                            Console.WriteLine($"Congratulations! You guessed the word \"{word}\" without any mistakes!");
                        System.Environment.Exit(0);
                    }
                }
                else if (!word.Contains(input))
                {
                    counter++;
                    switch (counter)
                    {
                        case 1:
                            Console.WriteLine("______");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 2:
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 3:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 4:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |     |");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 5:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |     |");
                            Console.WriteLine("   |     O");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 6:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |     |");
                            Console.WriteLine("   |     O");
                            Console.WriteLine("   |     | ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 7:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |     |");
                            Console.WriteLine("   |     O");
                            Console.WriteLine("   |     | ");
                            Console.WriteLine("   |    / \\");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine($"The right answer doesn't contain the letter \"{input}\" in it!");
                            Console.WriteLine("WARNING: Your next mistake will reveal the right word and you will lose!");
                            Console.Write("Please make your guess: ");
                            break;
                        case 8:
                            Console.WriteLine("   |-----    ");
                            Console.WriteLine("   |     |");
                            Console.WriteLine("   |     O");
                            Console.WriteLine("   |    /|\\");
                            Console.WriteLine("   |    / \\");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("___|___");
                            Console.WriteLine("You lost!");
                            Console.WriteLine($"The {type.ToLower()} you were looking for was {word}.");
                            TextWriter writer = new StreamWriter("Statistics.txt");
                            writer.WriteLine(gamesPlayed + 1);
                            writer.WriteLine(gamesWon);
                            writer.Close();
                            System.Environment.Exit(0);
                            break;
                    }
                }
            }
            Console.Write("Please make your guess: ");
            input = Console.ReadLine();
            if (input == "Quit")
            {
                TextWriter writer = new StreamWriter("Statistics.txt");
                writer.WriteLine(gamesPlayed + 1);
                writer.WriteLine(gamesWon);
                writer.Close();
            }
        }
    }
}