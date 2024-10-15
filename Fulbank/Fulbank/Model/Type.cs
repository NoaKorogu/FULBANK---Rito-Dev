using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

        public Type(int id, string name, decimal rate)
        {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;
        }
    }
}
