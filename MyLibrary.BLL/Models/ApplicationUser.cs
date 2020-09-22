using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.BLL.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        [Column(Order = 2)]
        [DisplayName("First Name")]        
        public string FirstName { get; set; }

        [PersonalData]
        [Column(Order = 3)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        public ApplicationUser()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
