using MyApp.Shared.DTOs;

namespace MyApp.Shared.Interfaces
{
    public interface IStateService
    {
        List<StateDto> GetStates();
    }
}
