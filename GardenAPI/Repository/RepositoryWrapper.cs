using Repository.Contracts;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IGardenRepository _garden;
        public IGardenRepository Garden
        {
            get
            {
                if(_garden == null)
                {
                    _garden = new GardenRepository(_context);
                }
                return _garden;
            }
        }
        public RepositoryWrapper (ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
       
 
    }
}
