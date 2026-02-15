using CSharpGym.Core;

namespace CSharpGym.Solutions.Level1_Easy;

public class Challenge003_CalculateBreakTime:IChallenge
{
    public string ChallengeName => "Calculate total break time from multiple time ranges"
    ;
    public Difficulty Level => Difficulty.Easy;
    
    private TimeSpan CalculateTotalBreakTime(List<(DateTime Start, DateTime End)> breaks)
    {
        TimeSpan result = TimeSpan.Zero;

        foreach (var b in breaks)
        {
            result += b.End - b.Start;
        }

        return result;
    }
    public void Run()
    {
        List<(DateTime Start, DateTime End)> breaks = new();

        Console.WriteLine("How many breaks do you want to enter?");
        int count = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter start time for break #{i + 1} (example: 2026-02-15 10:00):");
            DateTime start = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine($"Enter end time for break #{i + 1} (example: 2026-02-15 10:30):");
            DateTime end = DateTime.Parse(Console.ReadLine()!);

            breaks.Add((start, end));
        }

        TimeSpan total = CalculateTotalBreakTime(breaks);

        Console.WriteLine($"Total break time = {total}");
    }
}






