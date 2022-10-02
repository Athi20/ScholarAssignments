using System.ComponentModel.DataAnnotations;
using LabApp3.Attributes;

namespace LabApp3.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        [MinLength(3,ErrorMessage ="Please enter Username with more than 3 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Please Enter password with 1 Uppercase, " +
            "1 Number, 1 Special Char and 1 Lowercase Char), Min Length of 8 Chars)")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match")]
        public string ConfirmPassword { get; set; }


        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Mobile")]
        public string? Contact { get; set; }


        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool IsTerms { get; set; }
    }
}
