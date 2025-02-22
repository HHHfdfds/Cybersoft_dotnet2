using System.ComponentModel.DataAnnotations;
    public class ContactModel
    {
        [Required(ErrorMessage = "Full name is required.")]
        [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Message is required.")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
        public string Message { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a service.")]
        public string SelectedService { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must agree to the terms and conditions.")]
        public bool TermsAccepted { get; set; }
    }
