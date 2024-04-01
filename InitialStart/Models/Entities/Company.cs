using System.ComponentModel.DataAnnotations;

namespace InitialStart.Models.Entities
{
    public class Company
    {
        [StringLength(25,ErrorMessage ="opps it is more than 25")]
        [Required(ErrorMessage ="hey bro add a company name")]
        public string CompanyName { get; set; }
        [StringLength(50, ErrorMessage = "opps it is more than 50")]
        [Required(ErrorMessage = "hey bro add an address")]
        public string Address { get; set; }
        public string? Phone { get; set; }
        [EmailAddress(ErrorMessage ="please input valid email address")]
        [Required(ErrorMessage = "I need an email")]
        public string Email { get; set; }
        public int? EmployeeCount { get; set; }
    }
}


//company name must be lower than 25 character
//company name cannot be null

//address name must be lower than 50 character
//adress name cannot be null

//email can not be null and must be an email format

