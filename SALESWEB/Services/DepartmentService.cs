using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALESWEB.Data;
using SALESWEB.Models;

namespace SALESWEB.Services
{
    public class DepartmentService
    {
        private readonly SALESWEBContext _context;

        public DepartmentService(SALESWEBContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
