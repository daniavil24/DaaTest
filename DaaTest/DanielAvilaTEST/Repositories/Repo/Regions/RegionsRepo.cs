using Newtonsoft.Json;
using Repositories.DTOs;
using Repositories.Interface.Regiones;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repo.Regions
{
    public class RegionsRepo : IRegions
    {
        public RegionsDto GetCasesRegions(string iso)
        {
            string url = "";
            if (string.IsNullOrEmpty(iso))
            {
                url = "https://covid-19-statistics.p.rapidapi.com/reports";
            }
            else
            {
                url = "https://covid-19-statistics.p.rapidapi.com/reports?iso=" + iso;
            }    

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "7407234747msh5f3de430773ef11p1f3df4jsn13010ca6c236");
            request.AddHeader("x-rapidapi-host", "covid-19-statistics.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var regions = JsonConvert.DeserializeObject<RegionsDto>(response.Content);

            if (!string.IsNullOrEmpty(iso))
            {
                foreach (var item in regions.data)
                {
                    item.region.name = item.region.province;
                }
            }

            return regions;
        }

        public RegionesList GetRegions()
        {
            var client = new RestClient("https://covid-19-statistics.p.rapidapi.com/regions");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "7407234747msh5f3de430773ef11p1f3df4jsn13010ca6c236");
            request.AddHeader("x-rapidapi-host", "covid-19-statistics.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var regions = JsonConvert.DeserializeObject<RegionesList>(response.Content);
            return regions;
        }
    }
}
