using Repositories.DTOs;
using Repositories.Interface.Regiones;
using RestSharp;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repo.Regions
{
    public class RegionsRepo : IRegions
    {
        public RegionsDto GetRegionsDto()
        {
            var client = new RestClient("https://covid-19-statistics.p.rapidapi.com/reports?date=2020-04-16&q=US%20Alabama&region_name=US&iso=USA&region_province=Alabama&city_name=Autauga");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "7407234747msh5f3de430773ef11p1f3df4jsn13010ca6c236");
            request.AddHeader("x-rapidapi-host", "covid-19-statistics.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return null;
        }
    }
}
