using BusinessLogicLibrary.ViewModels;
//using DataLogicLibrary.Models;

namespace InterfaceLogicLibrary.Interfaces
{
    public interface IRatiosRepository
    {
        Task<List<Ratio>> GetAll();
        Task<Ratio?> GetById(int id);
        Task Insert(Ratio ratio);
        Task Update(Ratio ratio);
        Task Delete(int id);
    }
}