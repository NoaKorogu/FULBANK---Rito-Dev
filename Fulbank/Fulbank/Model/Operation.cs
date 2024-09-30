using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Operation
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Date { get; set; }

        public Operation(int id, decimal amount, decimal exchangeRate, string date)
        {
            this.Id = id;
            this.Amount = amount;
            this.ExchangeRate = exchangeRate;
            this.Date = date;
        }
    }
}
