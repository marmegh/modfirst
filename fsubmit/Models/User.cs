using System.ComponentModel.DataAnnotations;

namespace fsubmit.Models
{
    public abstract class BaseEntity {}
    public class Register : BaseEntity
    {
        [Display(Name = "First Name")]
        [Required]
        [MinLength(4)]
        public string FirstName {get; set;}
        [Display(Name = "Last Name")]
        [Required]
        [MinLength(4)]
        public string LastName {get; set;}
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Display(Name = "Password")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        [Display(Name = "Password Confirmation")]
        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string PWC {get; set;}

    }
    public class Login : BaseEntity
    {
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Display(Name = "Password")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get; set;}
    }
}