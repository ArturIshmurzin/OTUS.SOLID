namespace OTUS.SOLID.UseCase.Interfaces
{
    public interface IGameConfigProvider
    {
        (int, int) GetRange();

        int GetMaxCount();
    }
}
