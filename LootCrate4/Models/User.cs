using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LootCrate4.Models
{
    public class User
    {
        //[ForeignKey("User")]
        public string Id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Address is Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Zipcode is Required")]
        public int Zipcode { get; set; }
        public string AspNetUser { get; set; }

    }
}