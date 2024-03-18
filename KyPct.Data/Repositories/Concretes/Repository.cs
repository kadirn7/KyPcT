using KyPct.Data.Context;
using KyPcT.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyPct.Data.Repositories.Concretes
{
    public class Repository<T> where T: class,IEntitiyBase ,new() 
        //veri tabanı ile ilişkiyi konrtol ediyor.
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }
    }
}
// Task = void  Asenkrondaki ismidir.
