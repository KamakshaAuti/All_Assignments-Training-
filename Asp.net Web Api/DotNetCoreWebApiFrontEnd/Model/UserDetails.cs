using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Model
{
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int  UserId { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String Email { get; set; }
        public String Mobile { get; set; }
        public String Gender { get; set; }
       [Required]
        public String Password { get; set; }
        public DateTime MemberSince { get; set; }

    }
}
