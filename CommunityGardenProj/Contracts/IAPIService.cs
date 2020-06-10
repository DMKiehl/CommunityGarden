using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityGardenProj.Models;
using CommunityGardenProj.Services;

namespace CommunityGardenProj.Contracts
{
    public interface IAPIService
    {

        Task<GeoCode> GoogleGeocoding(string address);

        //Task<Maps> GoogleMaps();

        //Task<Garden> CreateGardenAPI();

    }
}
