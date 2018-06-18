using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class UrlBuilder
    {
        string protocol;
        string path;
        string domain;
        string ip;
        List<string> parameters = new List<string>();

        public UrlBuilder Protocol(string protocol)
        {
            this.protocol = protocol;
            return this;
        }

        public UrlBuilder Domain(string domain)
        {
            this.domain = domain;
            return this;
        }

        public UrlBuilder Path(string path)
        {
            this.path = path;
            return this;
        }

        public UrlBuilder Parameter(string parameter, string value)
        {
            parameters.Add(parameter + "=" + value);
            return this;
        }

        public UrlBuilder IP(string ip)
        {
            this.ip = ip;
            return this;
        }

        public Url Build()
        {
            if (string.IsNullOrEmpty(domain) && string.IsNullOrEmpty(ip))
            {
                throw new Exception("A url must have a domain or ip address");
            }
            string pro = string.IsNullOrEmpty(protocol) ? "http" : protocol;
            string address = string.IsNullOrEmpty(domain) ? ip : domain;
            return new Url()
            {
                Value = $"{pro}://{address}/{path}{(parameters.Count > 0 ? ("?" + String.Join("&", parameters.ToArray())) : "")}",
            };
        }
    }
}
