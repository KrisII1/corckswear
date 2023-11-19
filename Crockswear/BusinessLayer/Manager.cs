using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public List<Shoe> Shoes { get; set; }
        public List<Bill> Bills { get; set; }

        public Manager() {

            Bills= new List<Bill>();
            Shoes = new List<Shoe>();
        }

        public Manager(int id, string name, string email, string password, string phone) {
            this.Id= id;
            this.Name= name;
            this.Email= email;
            this.Password= password;
            this.Phone= phone;

            Bills = new List<Bill>();
            Shoes = new List<Shoe>();
        }

    }
}
