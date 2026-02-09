using CSharpGym.Core;

namespace CSharpGym.Solutions.Level2_Intermediate;

public class Challenge001_CountCharacters:IChallenge
{
    public string ChallengeName => "Count character frequencies in a string"
    ;
    public Difficulty Level => Difficulty.Intermediate;
    public void Run()
    {
        Console.WriteLine("Enter your words");
        var userInput = Console.ReadLine();
        
        Dictionary<char, int> CountCharacterFrequencies(string input)
        {
            
            Dictionary<char, int>  dir = new Dictionary<char, int>();
            foreach (var character in input)
            {
                if (dir.ContainsKey(character))
                {
            
                    dir[character] =  dir[character] + 1;
                }
                else
                {
                    dir[character] =  1;
                }
                
            }
            
            return dir;
        }


        foreach (var character in CountCharacterFrequencies(userInput))
        {
            Console.WriteLine($"{character.Key}: {character.Value}");
        }


    }
}