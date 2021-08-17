using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsControler: ControllerBase
    {
        public StoreContext _context { get; }

        public ProductsControler( StoreContext  Context)
        {
            _context = Context;
        }

        [HttpGet]
       public async Task<List<Product>> GetProducts()
        {
            return await  _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct( int id )
        {
            return await _context.Products.FirstOrDefaultAsync(x=> x.Id == id);
        }

    }
}
