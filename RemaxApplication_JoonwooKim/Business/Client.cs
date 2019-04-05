using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemaxApplication_JoonwooKim.Business
{
    public class Client:Person
    {
        public int RefClient { get; set; }
        public string ClientPhone { get; set; }
        public string ClientType { get; set; }
        public int RefEmp { get; set; }
        public int RefHouse { get; set; }

    }
}
