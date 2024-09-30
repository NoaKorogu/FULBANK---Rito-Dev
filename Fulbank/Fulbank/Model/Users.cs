using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }


        public Users(int id, string TheUsername, string ThePassword) {

            this.Id = id;
            this.Username = TheUsername;
            this.Password = ThePassword;
        }


        
    }
}
