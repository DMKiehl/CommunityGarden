using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CommunityGardenProj.Contracts;
using CommunityGardenProj.Models;
using Newtonsoft.Json;

namespace CommunityGardenProj.Services
{
    public class APICalls : IAPIService
    {
        public APICalls()
        {

        }


        public async Task<GeoCode> GoogleGeocoding(string address)
        {
            string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key=" + APIKey.GoogleMapsAPI;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GeoCode>(json);
                
            }

            return null;


        }

        //public async Task<APICalls> GoogleMaps()
        //{
           
        //}

        //public async Task<APICalls> GardenAPI()
        //{
           
        //}

    }
}
