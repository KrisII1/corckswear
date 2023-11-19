using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Order> orders { get; set; }

        public User() { 
            orders = new List<Order>();
        }

        public User(int id, string name, string email, string password)
        {
            this.Id= id;
            this.Name= name;
            this.Email= email;
            this.Password= password;

            orders = new List<Order>();
        }
    }
}
