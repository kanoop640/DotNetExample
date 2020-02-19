using System.Collections.Generic;

namespace DotNetExample
{
    public class HttpCockies
    {
        private Dictionary<string, string> _dictornary;
        public HttpCockies()
        {
            _dictornary = new Dictionary<string, string>();

        }
        public string this[string key]
        {
            get { return _dictornary[key]; }
            set { _dictornary[key] = value; }
        }
    }
}
