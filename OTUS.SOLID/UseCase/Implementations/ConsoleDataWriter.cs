using OTUS.SOLID.UseCase.Interfaces;

namespace OTUS.SOLID.UseCase.Implementations
{
    public class ConsoleDataWriter : IDataWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
