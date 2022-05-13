using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api_challenge.Data.Repositories
{
    public abstract class BaseRepository<TContext, Tmodel>
        where TContext: DbContext
        where Tmodel: class
    {
        public TContext _context;

        public async Task<Tmodel> GetAsync(int id)
        {
            return await _context.Set<Tmodel>().FindAsync(id);
        }

        public async Task<List<Tmodel>> GetAllAsync()
        {
            return await _context.Set<Tmodel>().AsNoTracking().ToListAsync();
        }
    }
}
