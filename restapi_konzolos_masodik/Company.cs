using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restapi_konzolos_jsonconvert
{
    internal class Company
    {
        string name;
        string catchPhrase;
        string bs;

        public string Name { get => name; set => name = value; }
        public string CatchPhrase { get => catchPhrase; set => catchPhrase = value; }
        public string Bs { get => bs; set => bs = value; }

        public Company(string name, string catchPhrase, string bs)
        {
            Name = name;
            CatchPhrase = catchPhrase;
            Bs = bs;
        }
    }
}
