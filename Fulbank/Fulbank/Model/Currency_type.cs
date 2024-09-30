using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    public class CurrencyType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public CurrencyType(string name)
        {
            this.Name = name;
        }
    } 
}
