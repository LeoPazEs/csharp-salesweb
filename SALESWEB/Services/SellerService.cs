using SALESWEB.Data;
using SALESWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALESWEB.Services
{
    public class SellerService
    {
        private readonly SALESWEBContext _context; 

        public SellerService(SALESWEBContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
