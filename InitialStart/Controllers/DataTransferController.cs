using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InitialStart.Controllers
{
    public class DataTransferController : Controller
    {
        //cshtml
        //create view
        //razor technology
        //view folder structure

        public IActionResult GetAll()
        {
            var productList = new List<Product>()
            {
                new(){Id=1,StockLevel=25,StockStatus=true,Title="TV"},
                new(){Id=1,StockLevel=225,StockStatus=true,Title="Usb"},
                new(){Id=1,StockLevel=215,StockStatus=true,Title="Phone"}
            };

            //return View(productList);

            #region Model
            #endregion
            #region ViewBag

            ViewBag.ProductList = productList;


            #endregion
            #region ViewData

            ViewData["Products"] = productList;

            #endregion
            #region TempData

            var jasonData = JsonConvert.SerializeObject(productList);

            TempData["Products"] = jasonData;




            //RedirectToAction
            //Json Serialize
            #endregion

            return RedirectToAction("TempDataExample","DataTransfer");


        }

        public IActionResult TempDataExample()
        {
            var data1 = ViewBag.ProductList;
            var data2 = ViewData["Products"];
            var data3 = TempData["Products"].ToString();

            var productList = JsonConvert.DeserializeObject<List<Product>>(data3);

            return View();
        }

    }
}
