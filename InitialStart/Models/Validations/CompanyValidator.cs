using System.ComponentModel.DataAnnotations;

namespace InitialStart.Models.Validations
{
    public class CompanyValidator
    {
        [StringLength(25, ErrorMessage = "opps it is more than 25")]
        [Required(ErrorMessage = "hey bro add a company name")]
        public string CompanyName { get; set; }

        [StringLength(50, ErrorMessage = "opps it is more than 50")]
        [Required(ErrorMessage = "hey bro add an address")]
        public string Address { get; set; }

        [EmailAddress(ErrorMessage = "please input valid email address")]
        [Required(ErrorMessage = "I need an email")]
        public string Email { get; set; }

    }
}
