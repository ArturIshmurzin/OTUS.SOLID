using Microsoft.Extensions.DependencyInjection;
using OTUS.SOLID.UseCase.Implementations;
using OTUS.SOLID.UseCase.Interfaces;

public static class Programm
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        IGameConfigProvider gameConfigProvider = serviceProvider.GetRequiredService<IGameConfigProvider>();
        IDataWriter dataWriter = serviceProvider.GetRequiredService<IDataWriter>();
        IDataReader dataReader = serviceProvider.GetRequiredService<IDataReader>();
        INumberGenerator numberGenerator = serviceProvider.GetRequiredService<INumberGenerator>();

        int maxCount = gameConfigProvider.GetMaxCount();
        (int, int) range = gameConfigProvider.GetRange();

        while (true)
        {
            int answer = numberGenerator.GetNumber(range.Item1, range.Item2);

            dataWriter.WriteLine($"У вас есть {maxCount} попыток чтобы угадать число в диапазоне [{range.Item1}, {range.Item2}]");

            int tryCount = 0;
            while (tryCount++ < maxCount)
            {
                dataWriter.WriteLine("Введите число");
                int num = dataReader.ReadNumber();

                if (num > answer)
                    dataWriter.WriteLine("Ваше число больше искомого");
                if (num < answer)
                    dataWriter.WriteLine("Ваше число меньше искомого");
                if (num == answer)
                {
                    dataWriter.WriteLine("Победа!");
                    break;
                }
            }

            if(tryCount > maxCount)
                dataWriter.WriteLine("Вы проиграли");
        }
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IDataReader, ConsoleDataReader>().
             AddSingleton<INumberGenerator, RandomEvenNumberGenerate>().
             AddSingleton<IDataWriter, ConsoleDataWriter>().
             AddSingleton<IGameConfigProvider, FileConfigProvider>();
    }
}