using BusinessLogicLibrary.ViewModels;

namespace BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces
{
    public interface ICreateRatio
    {
        Task ExecuteAsync(Ratio ratios);
    }
}