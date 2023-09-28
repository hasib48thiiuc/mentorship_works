namespace DependencyInjection.Services
{
    public class TransientService : ITransientService
    {

        private readonly DateTime _datetime;

        public TransientService()
        {
            _datetime = DateTime.Now;   
        }

        public string GetDateTime() => _datetime.ToString();
    }
}
