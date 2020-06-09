﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IGardenRepository : IRepositoryBase<Garden>
    {
        IEnumerable<Garden> GetAllGardens();
    }
}
