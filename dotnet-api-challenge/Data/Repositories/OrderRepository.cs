using dotnet_api_challenge.Core.Domain;
using dotnet_api_challenge.Core.Interfaces;
using dotnet_api_challenge.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api_challenge.Data.Repositories
{
    public class OrderRepository : BaseRepository<AppDbContext,Orders> , IOrdersRepository
    {
        public OrderRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public async Task<Orders> GetOrderByIdAsync(int id)
        {
            return await GetAsync(id);
        }

        public async Task<List<Orders>> GetOrdersAsync()
        {
            return await GetAllAsync();
        }
    }
}
