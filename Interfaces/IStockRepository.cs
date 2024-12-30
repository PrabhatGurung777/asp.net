using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Models;

namespace asp.net.Interfaces
{
   public interface IStockRepository
{
    Task<List<Stock>> GetAllAsync();
}

}