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

        public ICollection<Account> Accounts { get; set; }
        public ICollection<Operation> Operations { get; set; }

        public Users(int id, string TheUsername, string ThePassword) {

            this.Id = id;
            this.Username = TheUsername;
            this.Password = ThePassword;
        }
        public int getId()
        {
            return this.Id;
        }
        public string getUsername()
        {
            return this.Username;
        }

        public string getPassword()
        {
            return this.Password;
        }
    }
}