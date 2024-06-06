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
            uriBuilder.Query = $"EmployeeId={EmployeeId}&date={DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")}";
            //testing
                HttpClientHandler handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
                };
                using HttpClient client = new(handler);
           
     

            var response = await client.GetAsync(uriBuilder.Uri);
            if (!response.IsSuccessStatusCode)
            {
                //List<Entities.Task> tasks = new List<Entities.Task>();
                //tasks = await response.Content.ReadFromJsonAsync<List<Entities.Task>>();
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
            return response;
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

        public async Task<List<Entities.Assignment>> GetTasksForAsync(DateTime date, Employee employee)
        {
            string url = @$"Task/GetTasksFor";
            var response = await GetHttpAsync(url, employee.EmployeeId, date);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Assignment>();
            List<Entities.Assignment> assignments = await result.ToListAsync();

            return assignments;
        }
    }

    public interface ISosuService
    {
        Task<List<Entities.Assignment>> GetTasksForAsync(DateTime date, Employee employee);
    }
}
