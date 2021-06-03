using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string fName { get; set; }
        [Required]
        [StringLength(50)]
        public string mName { get; set; }
        [Required]
        [StringLength(50)]
        public string lName { get; set; }
        [Required]
        [StringLength(8)]
        public string gender { get; set; }
        [Required]
        [StringLength(100)]
        public string address { get; set; }
        [Required]
        [StringLength(50)]
        public string emailAddress { get; set; }
        [Required]
        [StringLength(11)]
        public string contactNo { get; set; }
    }
}
