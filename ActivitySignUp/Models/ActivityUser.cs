using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActivitySignUp.Models
{
    public class ActivityUser
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Activity")]
        public ActivityType? ActivityType { get; set; }

        [StringLength(50)]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [StringLength(500)]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Created Date")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }
    }
}