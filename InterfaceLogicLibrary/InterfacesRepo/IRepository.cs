using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLogicLibrary.InterfacesRepo
{
    public interface IRepository<TEntityBase> where TEntityBase : class
    {
        Task<List<TEntityBase>> GetAll();
        Task<TEntityBase?> GetById(int id);
        Task Insert(TEntityBase entidad);
        Task Update(TEntityBase entidad);
        Task Delete(int id);
    }
}
