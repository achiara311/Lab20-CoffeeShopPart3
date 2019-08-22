using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab20CoffeeShopDatabase.Models
{
    public partial class User
    {
        public int CoffeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        public string NickName { get; set; }
        [Required]
        [StringLength(50)]
        //[RegularExpression("\b[\\w\\.-]+@[\\w\\.-]+\\.\\w{2,4}\b/", ErrorMessage = "Must have @ symbol.")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }
        public string Password { get; set; }
        [RegularExpression(@"^[0-9]{3}[-]{1}[0-9]{3}[-]{1}[0-9]{4}$")]
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression("[0-9]{5}(-[0-9]{4})?")]
        public int ZipCode { get; set; }
        public float Funds { get; set; }
    }
}
