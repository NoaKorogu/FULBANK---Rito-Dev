using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public Type(string name, decimal rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
    }
}
