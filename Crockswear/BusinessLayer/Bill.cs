using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bill
    {
        [Key] public int Id { get; set; }
        public User User { get; set; }

        public string Address { get; set; }
        public string BankCard { get; set; }
        public decimal Price { get; set; }

        public List<Order> Orders { get; set; }
            


        public Bill() { 
            Orders = new List<Order>();
        }

        public Bill(int id, User user, string address, string bankcard, decimal price) {
            this.Id = id;
            this.User = user;
            this.Address = address;
            this.BankCard = bankcard;
            this.Price = price;

            Orders = new List<Order>();

        }


    }
}
