using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Currency_type
    {
        public int Id {get; set;}
        public string Name {get; set;}

        public Currency_type(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    } 
}
