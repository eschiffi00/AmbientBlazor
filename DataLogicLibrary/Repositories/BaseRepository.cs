using DataLogicLibrary.Models;
using InterfaceLogicLibrary.InterfacesRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : TEntityBase
    {
        protected DbContext _context;
        //protected IDbConnection _connection;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {   
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            //else
            //{
            //    throw new EntityNotFoundException($"No se encontró la entidad con id {id} en la base de datos");
            //}
                
        }
    }
}
