using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Data;
using asp.net.Interfaces;
using asp.net.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.net.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stock.ToListAsync();
        }

    }
    
    
        
}
