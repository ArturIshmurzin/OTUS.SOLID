using OTUS.SOLID.UseCase.Interfaces;

namespace OTUS.SOLID.UseCase.Implementations
{
    public class FileConfigProvider : IGameConfigProvider
    {
        public int GetMaxCount()
        {
            string[] config = File.ReadAllLines(@"./config.txt");

            string maxCount = config[0];

            if (int.TryParse(maxCount, out int reslt))
                return reslt;
            else
                throw new Exception($"Значение {maxCount} из настройки не является целым числом");
        }

        public (int, int) GetRange()
        {
            string[] config = File.ReadAllLines("./config.txt");

            string[] range = config[1].Split(" ");

            return (int.Parse(range[0]), int.Parse(range[1]));
        }
    }
}
