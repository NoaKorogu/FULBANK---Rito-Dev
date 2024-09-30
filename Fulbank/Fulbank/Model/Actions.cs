using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Actions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Actions(int id, string name, string description) { 
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
