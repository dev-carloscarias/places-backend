namespace Places.Application.Interfaces;

public interface IScreenService : IService<Screen>
{
    Task<Screen> GetByCode(string screen_code);
}