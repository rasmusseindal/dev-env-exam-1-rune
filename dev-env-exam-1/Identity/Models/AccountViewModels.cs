using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class AddGoalViewModel
    {
        [Required]
        [Display(Name = "ProfessionId")]
        public int ProfessionId { get; set; }

        //[Required]
        //[Display(Name = "ProfessionDropdown")]
        //public IEnumerable<Profession> DropDownItems { get; set; }
        //public ICollection<Profession> professions { get; }

        [Required]
        [Display(Name = "startLevel")]
        public string startLevel { get; set; }

        [Required]
        [Display(Name = "goalLevel")]
        public string goalLevel { get; set; }
    }

    public class ProfessionViewModel
    {
        [Required]
        [Display(Name = "ProfessionName")]
        public string ProfessionName { get; set; }

        [Required]
        [Display(Name = "ProfessionDescription")]
        public string ProfessionDescription { get; set; }

        [Required]
        [Display(Name = "ownExperience")]
        public string ownExperience { get; set; }

        [Required]
        [Display(Name = "employeesWithExperience")]
        public string employeesWithExperience { get; set; }
    }
    public class AddProfessionViewModel
    {
        [Required]
        [Display(Name = "ProfessionName")]
        public string ProfessionName { get; set; }

        [Required]
        [Display(Name = "ProfessionDescription")]
        public string ProfessionDescription { get; set; }
    }

    public class RegisterCompanyViewModel
    {
        [Required]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "CompanyDescription")]
        public string CompanyDescription { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display (Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
