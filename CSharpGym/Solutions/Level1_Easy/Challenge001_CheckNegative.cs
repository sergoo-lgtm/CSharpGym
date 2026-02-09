using System;
using System.Linq;
using CSharpGym.Core; // لازم تعمل using للـ Core

namespace CSharpGym.Solutions.Level1_Easy
{
    public class Challenge001_CheckNegative : IChallenge
    {
        public string ChallengeName => "Check for Negative Numbers";
        public Difficulty Level => Difficulty.Easy; 

        public void Run()
        {
            Console.WriteLine("Enter a list of numbers separated by comma (e.g. 5, -1, 3):");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) return;

            List<int> checkedList = input
                .Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToList();
            var negative = checkedList.Where(n => n < 0);
            if(checkedList.Any(n=>n<0))
            {
                Console.WriteLine("List have negative numbers.");
                foreach(var n in negative)  Console.Write(n+" ,");
            }

            else 
            {
                Console.WriteLine("List doesn't has negative number.");
            }

        }
    }
}