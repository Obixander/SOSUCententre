using SosuCentre.Entities;
using System.Net.Http.Json;


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

        public List<Entities.Task> GetTasksFor(DateTime date, Employee employee)
        {
            UriBuilder uriBuilder = new UriBuilder(baseUri);
            uriBuilder.Path = "Assignment/GetAssignmentsForEmployeeByDate";
            using HttpClient client = new();
            client.BaseAddress = uriBuilder.Uri;

            var response = client.GetAsync(uriBuilder.Uri.AbsoluteUri).Result;
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Task>();
            List<Entities.Task> assignments = result.ToListAsync().Result;

            return assignments;
        }
    }

    public interface ISosuService
    {
        List<Entities.Task> GetTasksFor(DateTime date, Employee employee);
    }
}
