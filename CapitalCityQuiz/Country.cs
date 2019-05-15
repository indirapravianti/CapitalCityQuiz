using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CapitalCityQuiz
{
    class Country
    {
        public static Dictionary<string, string> GetCountryName()
        {
            Dictionary<string, string> countryDict = new Dictionary<string, string>();
            var client = new RestClient("https://restcountries.eu/rest/v2/all?fields=name;capital");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonArray countryArray = (JsonArray)SimpleJson.DeserializeObject(response.Content);
            foreach (JsonObject country in countryArray)
            {
                countryDict.Add((string)country["name"], (string)country["capital"]);
            }

            return countryDict; 
        }

        public static List<string> GetCountryList()
        {
            List<string> countryList = new List<string>();
            var client = new RestClient("https://restcountries.eu/rest/v2/all?fields=name;capital");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonArray countryArray = (JsonArray)SimpleJson.DeserializeObject(response.Content);
            foreach(JsonObject country in countryArray)
            {
                countryList.Add((string)country["name"]);
            }

            return countryList;
        }
    }
}
