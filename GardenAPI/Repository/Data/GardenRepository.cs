using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CreateGarden(Garden garden)
        {
            Create(garden);
        }

        public void EditGarden(Garden garden)
        {
            Update(garden);
        }

        public void DeleteGarden(Garden garden)
        {
            Delete(garden);
        }

        public Garden GetByID(int id)
        {
            var thisGarden = FindByCondition(g => g.GardenId == id).SingleOrDefault();
            return (thisGarden);

        }
    }
}
