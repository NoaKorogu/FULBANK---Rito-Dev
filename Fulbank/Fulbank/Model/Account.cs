using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Fulbank.Model
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int IdHolder { get; set; }
        public int IdCurrency { get; set; }
        public int IdType { get; set; }
        public int? IdSubstitute { get; set; }
        public User Holder { get; set; }
        public CurrencyType Currency { get; set; }
        public Type AccountType { get; set; }
        public User Substitute { get; set; }

        public ICollection<Operation> Operations { get; set; }

        public Account(decimal Balance) 
        {
            this.Balance = Balance;
        }
    }
}
