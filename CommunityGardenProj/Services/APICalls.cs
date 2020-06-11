using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CommunityGardenProj.Contracts;
using CommunityGardenProj.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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



        public async Task<Garden> GardenDetailAPI(int id)
        {
            var url = "https://localhost:44329/api/Garden/" + id;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var result = JObject.Parse(json).ToString();
                return JsonConvert.DeserializeObject<Garden>(result);

            }
            return null;

        }


    }
}
