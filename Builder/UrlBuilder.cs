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

        public Url Build()
        {
            return new Url()
            {
                Value = $"{protocol}://{domain}/{path}{(parameters.Count > 0 ? ("?" + String.Join("&", parameters.ToArray())) : "")}",
            };
        }
    }
}
