using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    public class Operation
    {
        public int Id { get; set; }
        public int Account1 { get; set; }
        public int? Account2 { get; set; }
        public decimal Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal ExchangeRate { get; set; }
        public int IdAction { get; set; }
        public DateTime Date { get; set; }
        public int IdUser { get; set; }
        public int IdTerminal { get; set; }

        public Account AccountFrom { get; set; }
        public Account AccountTo { get; set; }
        public Action Action { get; set; }
        public User User { get; set; }
        public Terminals Terminal { get; set; }

        public Operation(decimal amount, decimal exchangeRate, DateTime date_)
        {
            this.Amount1 = amount;
            this.ExchangeRate = exchangeRate;
            this.Date = date_;
        }
    }
}
