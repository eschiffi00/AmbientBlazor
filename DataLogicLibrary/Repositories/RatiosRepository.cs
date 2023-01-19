using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogicLibrary.Models;
using InterfaceLogicLibrary;
using InterfaceLogicLibrary.InterfacesRepo;
namespace DataLogicLibrary.Repositories
{
    public class RatiosRepository : BaseRepository<Ratio>, IRepository<Ratio>
    {
        public RatiosRepository(DbContext context, IDbConnection connection) : base(context)
        {
        }

        //public IEnumerable<Ratio> GetByName(string name)
        //{
        //    return _connection.Query<Ratio>("SELECT * FROM Ratios WHERE Name = @name", new { name });
        //}
    }
}
