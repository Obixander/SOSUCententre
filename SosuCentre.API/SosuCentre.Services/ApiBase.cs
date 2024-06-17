using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SosuCentre.Entities;
using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Text;


namespace SosuCentre.Services
{
    //DO SERPATORIONS OF CONCERNS SOON
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
            uriBuilder.Query = $"EmployeeId={EmployeeId}&date={DateTime.Now.ToString("yyyy-MM-dd")}";
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

        protected virtual async Task<HttpResponseMessage> GetByIdHttpAsync(string url, int id)
        {
            UriBuilder uriBuilder = new(baseUri + url);
            uriBuilder.Query = $"id={id}";
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
            };
            using HttpClient client = new(handler);

            var response = await client.GetAsync(uriBuilder.Uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
            return response;
        }

        //This somehow works and i dont understand why
        protected virtual async void PutHttpAsync(string url, Assignment data)
        {
            UriBuilder uriBuilder = new(baseUri + url);
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
            };
            using HttpClient client = new(handler);
            try
            {
                var response = await client.PutAsJsonAsync(uriBuilder.Uri, data);
                
                if (response.IsSuccessStatusCode)
                {
                    //do something later here
                }
                //this will always fail and be caught by the catch but the put request will still be successful
            }
            catch (Exception ex)
            {
                throw;
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

        public async Task<List<Entities.Assignment>> GetTasksForAsync(DateTime date, Employee employee)
        {
            string url = @$"Task/GetAssignmentsOn";
            var response = await GetHttpAsync(url, employee.EmployeeId, date);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Assignment>();
            List<Entities.Assignment> assignments = await result.ToListAsync();

            return assignments;
        }

        public void UpdateAssignment(Assignment assignment)
        {
            try
            {
                string url = @$"Task/";
                PutHttpAsync(url, assignment);
               
            }
            catch (Exception ex)
            {
                throw;
            }
            


        }
    }

    public interface ISosuService
    {
        Task<List<Entities.Assignment>> GetTasksForAsync(DateTime date, Employee employee);
        void UpdateAssignment(Assignment assignment);
    }

    public interface IUserService
    {
        void SetUserId(int value);
        int GetUserId();
    }

    //this has unecessary methods as you could just use the property directly
    public class UserService : IUserService
    {
        private int userId;

        public int UserId { get => userId; set => userId = value; }

        public int GetUserId()
        {
            return UserId;
        }

        public void SetUserId(int value)
        {
            UserId = value;

        }

        
      
    }

}
