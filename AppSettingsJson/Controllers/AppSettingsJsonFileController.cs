using AppSettingsJson.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSettingsJson.Controllers
{
    public class AppSettingsJsonFileController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly EmailSettings _emailSettings;

        public AppSettingsJsonFileController(IConfiguration configuration, IOptions<EmailSettings> option)
        {
            _configuration = configuration;
            _emailSettings = option.Value;
        }

        public IActionResult Index()
        {
            var companyList = new List<string>() { "company1", "company2" };
            CustomEmailSender(companyList);

            return View();
        }
        public IActionResult Index2()
        {
            var employeeList = new List<string>() { "employee1", "employee2" };
            CustomEmailSender(employeeList);

            return View();
        }
        public IActionResult Index3()
        {
            var customerList = new List<string>() { "customer1", "customer2" };
            CustomEmailSender(customerList);

            return View();
        }

        #region Explanation

        //during development process we might need to use static values in our codes but we should not use them directly in our codes, If you are using best practise methods.

        public void CustomEmailSender(List<string> emailList)
        {
            string host = "smtp.gmail.com";
            string port = "587";
            string from = "test@gmail.com";
            string password = "12345";

            // we can send our emails to EMAIL LIST
        }


        #endregion

        #region DataAdd-To-APPsettingsJSON

        //we use Json format to add our static information. Lets have look and add some data.

        #endregion

        #region DataReceive-From-APPsettingsJSON

        //indexer
        //getSection
        //get
        //option pattern

        public IActionResult DataReceive()
        {
            var connectionString = _configuration["ConnectionString"];

            var host = _configuration["EmailSettings:Host"];
            var port = _configuration["EmailSettings:Port"];
            var emailAddress = _configuration["EmailSettings:Email:Address"];
            var password = _configuration["EmailSettings:Email:Password"];

            var testPurposePass = _configuration["EmailPassword"];

            var host2 = _configuration.GetSection("EmailSettings:Host");

            var emailInfo = _configuration.GetSection("EmailSettings").Get(typeof(EmailSettings));

            var emailInfo2 = _emailSettings;
            emailInfo2.Email.Password = Environment.GetEnvironmentVariable("EmailPassword");

            return View();
        }

        #endregion



    }
}
