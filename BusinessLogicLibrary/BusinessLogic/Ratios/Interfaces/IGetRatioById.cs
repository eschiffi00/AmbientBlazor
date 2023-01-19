using BusinessLogicLibrary.ViewModels;

namespace BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces
{
    public interface IGetRatioById
    {
        Task<Ratio>ExecuteAsync(int Id);
    }
}