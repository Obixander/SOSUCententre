using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SosuCentre.Entities;
using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;


namespace SosuCentre.Services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;
        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {
            
        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url, int EmployeeId, DateTime date)
        {
            

            UriBuilder uriBuilder = new(baseUri + url);
            uriBuilder.Query = $"EmployeeId={EmployeeId}&date={date.ToString("yyyy-MM-dd")}";
            using HttpClient client = new();
            //This returns null fix
            //this does not work as the android emulator is a considered a external device and cannot access localhost(127.0.0.1) where the api is hosted
            //atleast that is what i think based on testing and research
            var response = await client.GetAsync(uriBuilder.Uri);
            if (response.IsSuccessStatusCode)
            {
                List<Entities.Task> tasks = new List<Entities.Task>();
                tasks = response.Content.ReadFromJsonAsync<List<Entities.Task>>().Result;
                return response;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }

    }

    public class ApiService : ApiBase, ISosuService
    {
        public ApiService(Uri baseUri) : base(baseUri)
        {
            
        }       
        ///  <exception cref="UriFormatException">Thrown when the baseUri is not a valid URI</exception></exception>
        public ApiService(string baseUri) : base(baseUri)
        {
        }

        public async Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee)
        {
            string url = @$"Task/GetTasksFor";
            var response = await GetHttpAsync(url, employee.EmployeeId, date);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Task>();
            List<Entities.Task> assignments = await result.ToListAsync();

            return assignments;
        }
    }

    public interface ISosuService
    {
        Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee);
    }
}
