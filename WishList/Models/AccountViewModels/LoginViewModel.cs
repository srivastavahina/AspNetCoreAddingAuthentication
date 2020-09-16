using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class LoginViewModel
    {[Required]
    [EmailAddress]
        public int Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
