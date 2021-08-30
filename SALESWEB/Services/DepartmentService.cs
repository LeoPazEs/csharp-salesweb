using System;
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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
