using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSharpGym.Core; // تأكد إنك عامل using للـ Core عشان يشوف IChallenge

namespace CSharpGym
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. تجميع كل الحلول باستخدام Reflection
            var challenges = LoadChallenges();

            // === 🛑 التعديل هنا: لو مفيش أسئلة، استنى اليوزر يدوس زرار ===
            if (challenges.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============================================");
                Console.WriteLine("⚠️  No challenges found!");
                Console.WriteLine("=============================================");
                Console.WriteLine("Hint: Create a class in 'Solutions' folder that implements 'IChallenge'.");
                Console.WriteLine("Example: public class MyChallenge : IChallenge { ... }");
                Console.WriteLine("=============================================");
                Console.ResetColor();
                
                Console.WriteLine("\n👉 Press any key to exit...");
                Console.ReadKey(); // هنا البرنامج هيقف مستنيك
                return;
            }

            // 2. القائمة الرئيسية (Loop 1)
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("       💪 Youssef's C# Gym - Main Menu       ");
                Console.WriteLine($"       (Total Challenges: {challenges.Count})");
                Console.WriteLine("=============================================");
                Console.WriteLine("[1] ⭐    Easy (Beginner)");
                Console.WriteLine("[2] ⭐⭐   Intermediate (Hero)");
                Console.WriteLine("[3] ⭐⭐⭐  Advanced (Legend)");
                Console.WriteLine("[0] Exit Application");
                Console.WriteLine("=============================================");
                Console.Write("👉 Select Difficulty: ");

                string input = Console.ReadLine();

                if (input == "0") break;

                Difficulty? selectedLevel = input switch
                {
                    "1" => Difficulty.Easy,
                    "2" => Difficulty.Intermediate,
                    "3" => Difficulty.Advanced,
                    _ => null
                };

                if (selectedLevel.HasValue)
                {
                    // الدخول للقائمة الفرعية
                    ShowLevelMenu(challenges, selectedLevel.Value);
                }
                else
                {
                    ShowError("Invalid selection! Please choose 1, 2, or 3.");
                }
            }
        }

        // القائمة الفرعية لعرض أسئلة مستوى معين (Loop 2)
        static void ShowLevelMenu(List<IChallenge> allChallenges, Difficulty level)
        {
            // فلترة الأسئلة حسب المستوى المختار
            var levelChallenges = allChallenges
                .Where(c => c.Level == level)
                .OrderBy(c => c.GetType().Name) // الترتيب حسب اسم الملف
                .ToList();

            while (true)
            {
                Console.Clear();
                string stars = level == Difficulty.Easy ? "⭐" : level == Difficulty.Intermediate ? "⭐⭐" : "⭐⭐⭐";
                Console.WriteLine($"=== {stars} {level} Challenges ({levelChallenges.Count}) ===");

                if (levelChallenges.Count == 0)
                {
                    Console.WriteLine("\nNo challenges added in this level yet!");
                    Console.WriteLine("\n[0] Back to Main Menu");
                    
                    Console.Write("\n👉 Press 0 to go back: ");
                    Console.ReadLine(); // مستني تدوس انتر عشان يرجع
                    return;
                }
                else
                {
                    for (int i = 0; i < levelChallenges.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {levelChallenges[i].ChallengeName}");
                    }
                    Console.WriteLine("\n[0] 🔙 Back to Main Menu");
                }
                
                Console.WriteLine("=============================================");
                Console.Write("👉 Choose challenge number: ");
                
                string choice = Console.ReadLine();

                if (choice == "0") return; // الرجوع للقائمة الرئيسية

                if (int.TryParse(choice, out int index) && index > 0 && index <= levelChallenges.Count)
                {
                    RunChallenge(levelChallenges[index - 1]);
                }
                else
                {
                    ShowError("Invalid number!");
                }
            }
        }

        static void RunChallenge(IChallenge challenge)
        {
            Console.Clear();
            Console.WriteLine($"*** 🏃 Running: {challenge.ChallengeName} ***\n");
            try
            {
                challenge.Run();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n⚠️ Runtime Error: {ex.Message}");
                Console.ResetColor();
            }
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static List<IChallenge> LoadChallenges()
        {
            var interfaceType = typeof(IChallenge);
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (IChallenge)Activator.CreateInstance(t))
                .ToList();
        }

        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n❌ {message}");
            Console.ResetColor();
            System.Threading.Thread.Sleep(1000); // يستنى ثانية عشان تقرأ الخطأ
        }
    }
}