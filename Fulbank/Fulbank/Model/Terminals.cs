using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    public class Terminals
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int balance { get; set; }

        // Navigation properties
        public ICollection<Operation> Operations { get; set; }

        public Terminals(string Location, int balance) 
        { 
            this.Location = Location;
            this.balance = balance;
        }
    } 
}
