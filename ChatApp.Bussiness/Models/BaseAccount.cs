using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Bussiness.Models
{
    public abstract class BaseAccount
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Username { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        [Required]
        public string  Emailaddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
