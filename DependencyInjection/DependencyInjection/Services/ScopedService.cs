namespace DependencyInjection.Services
{
    public class ScopedService : IScopedService
    {


        private readonly DateTime _datetime;

        public ScopedService()
        {
            _datetime = DateTime.Now;
        }

        public string GetDateTime() => _datetime.ToString();
    }
}
