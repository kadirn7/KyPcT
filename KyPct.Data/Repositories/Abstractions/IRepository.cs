using KyPcT.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyPct.Data.Repositories.Abstractions
{
    public interface IRepository<in T> where T : class, IEntitiyBase ,  new()
    {
        Task AddAsync(T entity);
    }
}
