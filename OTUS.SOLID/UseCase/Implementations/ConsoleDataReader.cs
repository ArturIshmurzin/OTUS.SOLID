using OTUS.SOLID.UseCase.Interfaces;

namespace OTUS.SOLID.UseCase.Implementations
{
    public class ConsoleDataReader : IDataReader
    {
        public int ReadNumber()
        {
            string? inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int value))
                return value;
            else
                throw new InvalidOperationException($"Значение {inputString} не является целым числом");
        }
    }
}
