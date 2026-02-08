namespace CSharpGym.Core
{
    public interface IChallenge
    {
        string ChallengeName { get; }
        Difficulty Level { get; }
        void Run();
    }
}