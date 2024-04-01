using System.ComponentModel.DataAnnotations;

namespace InitialStart.Models.Entities
{
    public class Company
    {       
        public string CompanyName { get; set; }      
        public string Address { get; set; }
        public string? Phone { get; set; }        
        public string Email { get; set; }
        public int? EmployeeCount { get; set; }
    }
}

//1- this class is an entity => keeps our properties located in databese
//2- this class demonstrate results to user
//3- this class contains validations


//company name must be lower than 25 character
//company name cannot be null

//address name must be lower than 50 character
//adress name cannot be null

//email can not be null and must be an email format

