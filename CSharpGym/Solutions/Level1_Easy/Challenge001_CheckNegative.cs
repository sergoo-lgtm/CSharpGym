using System;
using System.Linq;
using CSharpGym.Core; // لازم تعمل using للـ Core

namespace CSharpGym.Solutions.Level1_Easy
{
    public class Challenge001_CheckNegative : IChallenge
    {
        // 1. البيانات التعريفية للسؤال
        public string ChallengeName => "Check for Negative Numbers";
        public Difficulty Level => Difficulty.Easy; // حدد المستوى هنا

        // 2. كود الحل
        public void Run()
        {
            Console.WriteLine("Enter a list of numbers separated by comma (e.g. 5, -1, 3):");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) return;

            // اللوجيك
            var numbers = input.Split(',').Select(int.Parse).ToArray();
            bool hasNegative = numbers.Any(n => n < 0);

            // النتيجة
            if (hasNegative)
                Console.WriteLine("✅ Result: The list contains negative numbers.");
            else
                Console.WriteLine("❌ Result: No negative numbers found.");
        }
    }
}