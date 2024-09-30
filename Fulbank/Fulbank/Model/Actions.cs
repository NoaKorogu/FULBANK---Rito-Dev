using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    public class Actions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Operation> Operations { get; set; }
    

        public Actions(string name, string description) 
        { 
                this.Name = name;
                this.Description = description;
        }
    }
}
