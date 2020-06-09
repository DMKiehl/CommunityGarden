using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class GardenRepository : RepositoryBase<Garden>, IGardenRepository
    {
        public GardenRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {


        }

        public IEnumerable<Garden> GetAllGardens()
        {
            var gardens = FindAll();
            return gardens;
        }

    }
}
