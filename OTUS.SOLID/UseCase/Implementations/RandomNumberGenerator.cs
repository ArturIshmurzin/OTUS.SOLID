using OTUS.SOLID.UseCase.Interfaces;

namespace OTUS.SOLID.UseCase.Implementations
{
    public class RandomNumberGenerator : INumberGenerator
    {
        public int GetNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
