using CSharpGym.Core;
namespace CSharpGym.Solutions.Level1_Easy;

public class Challenge002_SplitName:IChallenge
{
    public string ChallengeName => "Split a full name into first and last names ";
    public Difficulty Level => Difficulty.Easy;
    public void Run()
    {
        Console.WriteLine("Enter your FullName eg('yousef serag')");
        var username = Console.ReadLine();

        (string firstName, string lastName) SplitFullName(string fullName)
        {
            var spliting = fullName.Split(' ');
            if (spliting.Length < 2){Console.WriteLine("enter right full name");return("NonValid","Input");}

            Console.WriteLine($"your First Name is [{spliting[0]}], and your Last Name is [{spliting[1]}]");
            return(spliting[0],spliting[1]);
        }

        SplitFullName(username);
    }
}
        
        