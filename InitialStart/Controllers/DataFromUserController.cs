using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class DataFromUserController : Controller
    {
        #region ByUsingModel
        //[HttpGet]
        //public ActionResult AddProduct()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Addproduct(OldProduct product)
        //{
        //    return View();
        //}
        #endregion
        #region ByUsingIFormCollection
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addproduct(IFormCollection data)
        {

            var name = data["Name"];
            var quantity = data["Quantity"];
            var price = data["Price"];
            return View();
        }
        #endregion
    }
    public class NewProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class OldProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
