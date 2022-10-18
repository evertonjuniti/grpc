using System.Net.Http.Json;

namespace NetCoreHelperLib
{
    public class RestService : IRestService
    {
        private HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<GenericModel?> GetMessageAsync(string id)
        {
            string path = "http://localhost:8080/api/generics/" + id;
            GenericModel? message = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
                message = await response.Content.ReadFromJsonAsync<GenericModel>();

            return message;
        }
    }
}
