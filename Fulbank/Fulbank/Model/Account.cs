using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Account
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public Account(int id, decimal Balance) {
            this.Id = id;
            this.Balance = Balance;
        }
    }
}
