using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStart.Models
{
    public class Cart
    {
        public Cart()
        {
        }

        [Key]
        public int Id { get; set; }

        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated
        {
            get;
            set;
        }
        public virtual Product Product
        {
            get;
            set;
        }

    }
}
