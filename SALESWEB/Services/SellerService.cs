using SALESWEB.Data;
using SALESWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SALESWEB.Services.Exceptions;

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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        } 

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        } 

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            /* 
             * Controller conversa com a camada Services ou seja .... não lida com exeções de acesso a dados apenas com exeções de serviço
             * A camada de serviços captura a erros da camada de acesso a dados e retorna pro controlador como exeções de serviço!
            */
            catch (DbUpdateConcurrencyException  e)
            {
                throw new DbConcurrencyException(e.Message);
            }


        }
    }
}
