using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Shoe Shoe { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("shoe")]
        public OrderStatus Status { get; set; }
        public decimal Shoeprice { get; set; }

        public Bill Bill { get; set; }
        
         
        public Order    ()
        {

        }



        public Order(int id, User user, Shoe shoe, int quantity, decimal price, decimal shoeprice, Bill bill,OrderStatus status)
        {
            this.Id= id;
            this.User= user;
            this.Shoe= shoe;
            this.Quantity= quantity;
            this.Price= price;
            this.Shoeprice= shoeprice;
            this.Bill = bill;
            this.Status= status;


        }
















    }
}
