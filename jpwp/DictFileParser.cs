using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jpwp
{
    public class DictFileParser
    {
        public string filePath = @"C:\Users\Lenovo\Desktop\DICT.txt";
        public string[] lines;
        static Random rand = new Random();
        
        public DictFileParser() 
        {
            lines = File.ReadAllLines(filePath);
        } 

        public void getRandomLine(ref string correct, ref List<string> randomized)
        {
            string line = lines[rand.Next(lines.Length)];

            var spellings = line.Split(';').ToList();
            randomized = spellings.OrderBy(x => Guid.NewGuid()).ToList();

            correct = spellings[0];
        }

        public List<string> getCorrectSpellings()
        {
            List<string> correct = new List<string>();

            foreach (string line in lines)
            {
                var spellings = line.Split(";").ToList();
                correct.Add(spellings[0]);
            }

            return correct;
        }
        
        public void Parse()
        {
            foreach (var line in lines)
            {
                var words = line.Split(';');
                var randomizedWords = words.OrderBy(x => Guid.NewGuid()).ToList();

                for (int i = 0; i < randomizedWords.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {randomizedWords[i]}");
                }

                Console.Write("Choose the correct spelling (1-3): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                {
                    if (randomizedWords[choice - 1] == words[0])
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. The right answer was: " + words[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            }
        }

    }
}
