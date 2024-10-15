using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Terminals
    {
        public int Id {get; set;}
        public string Location{get; set;}
        public int balance {get; set;}

        public Terminals(int id, string Location, int balance) { 
            this.Id = id;
            this.Location = Location;
            this.balance = balance;
        }
    } 
}
