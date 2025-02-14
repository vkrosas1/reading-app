using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTracking.Objects
{
    public class Account
    {
        private string id;
        private string name;

        public Account(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
