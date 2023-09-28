namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {

        private readonly DateTime _dateTime;

        public SingletonService()
        {
            _dateTime = DateTime.Now;
        }

        public string GetDateTime() => _dateTime.ToString();
    }

}
