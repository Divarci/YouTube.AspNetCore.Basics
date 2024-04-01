using InitialStart.Models.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InitialStart.Models.ViewModels
{
    [ModelMetadataType(typeof(CompanyValidator))]
    public class CompanyListVM
    {       
        public string CompanyName { get; set; }      
        public string Address { get; set; }
        public string? Phone { get; set; }      
        public string Email { get; set; }
    }
}
