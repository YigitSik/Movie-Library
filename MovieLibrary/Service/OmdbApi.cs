using MovieLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieLibrary.Service
{

    public static class OmdbApi
    {

        public const string BaseUrl = "https://www.omdbapi.com/";
        public const string ApiKey = "c21c54d6";
        public const string SearchEndpoint = "?s={0}&apikey={1}";
        public const string SeacrchByIdEndpoint = "?i={0}&apikey={1}";


        public static async Task<SearchResponse> GetMoviePreview(string Query)
        {
            SearchResponse searchResponse = new SearchResponse();
            string url = BaseUrl + string.Format(SearchEndpoint, Query, ApiKey);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                searchResponse = JsonConvert.DeserializeObject<SearchResponse>(json);
            }
            return searchResponse;
        }

        public static async Task<TBL_MOVIE> GetMovieFromApi(string imdbID)
        {
            TBL_MOVIE movie = new TBL_MOVIE();
            string url = BaseUrl + string.Format(SeacrchByIdEndpoint, imdbID, ApiKey);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<TBL_MOVIE>(json);
            }
            return movie;
        }



    }

}


