namespace SosuCentre.Services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;
        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

        }

    }
}
