using BusinessLogicLibrary.ViewModels;

namespace BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces
{
    public interface IUpdateRatio
    {
        Task ExecuteAsync(Ratio ratios);
    }
}