using dotnet_api_challenge.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api_challenge.Core.Interfaces
{
    public interface IOrdersRepository
    {
        Task<Orders> GetOrderByIdAsync(int id);
        Task<List<Orders>> GetOrdersAsync();
    }
}
