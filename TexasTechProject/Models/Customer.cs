using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TexasTechProject.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BecameCustomer { get; set; }
        public bool Active { get; set; }

    }
}
