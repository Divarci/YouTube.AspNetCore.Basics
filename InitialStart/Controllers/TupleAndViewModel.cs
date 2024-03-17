using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class TupleAndViewModel : Controller
    {
        public IActionResult Test()
        {
            Product product = new()
            {
                Id = 1,
                StockLevel = 15,
                StockStatus = true,
                Title="Fryer"
            };

            Category category = new()
            {
                Id = 1,
                Name = "Electronics"
            };

            #region MultiDataTransfer
            #endregion

            #region UsingViewModel
            //ProductCategory productCategory = new()
            //{
            //    Category = category,
            //    Product = product
            //};
            //return View(productCategory);
            #endregion
            #region UsingTuple

            var productCategory = (product, category);


            return View(productCategory);
            #endregion



        }
    }
}
