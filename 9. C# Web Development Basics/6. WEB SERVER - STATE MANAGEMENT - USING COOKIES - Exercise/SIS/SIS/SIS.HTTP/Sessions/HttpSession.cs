using System.Collections.Generic;

namespace SIS.HTTP.Sessions
{
    public class HttpSession : IHttpSession
    {
        public string Id { get; private set; }
        private readonly Dictionary<string, object> parameters;

        public HttpSession(string id)
        {
            parameters = new Dictionary<string, object>();
            Id = id;
        }

        public void AddParameter(string name, object parameter)
        {
            if (!parameters.ContainsKey(name))
            {
                parameters.Add(name, parameter);
            }
        }

        public void ClearParameters()
        {
            parameters.Clear();
        }

        public bool ContainsParameter(string name)
            => parameters.ContainsKey(name);

        public object GetParameter(string name)
        {
            if (parameters.ContainsKey(name))
            {
                return parameters[name];
            }

            return null;
        }
    }
}
