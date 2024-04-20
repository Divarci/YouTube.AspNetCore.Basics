using ApiProject.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //....baseaddress /api/home/
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var itemList = DummyData.Products;

            return Ok(itemList);
        }

        //....baseaddress /api/home/id
        [HttpGet("{id}")]
        public IActionResult GeyProductById(int id)
        {
            var itemList = DummyData.Products;

            var item = itemList.Find(x => x.Id == id);

            return Ok(item);
        }

        //.....baseaddress/api/home/
        [HttpPost]
        public IActionResult CreateProduct(Product request)
        {
            var itemList = DummyData.Products;

            itemList.Add(request);

            return Created("test", request);
        }

        
        [HttpPost("[action]")]
        public IActionResult CreateProductByRawMaterial(Product request)
        {
            var itemList = DummyData.Products;

            itemList.Add(request);

            return Created("test", request);
        }


        //.....baseaddress/api/home/
        [HttpPut]
        public IActionResult UpdateProduct(Product request)
        {
            var itemList = DummyData.Products;

            var existItem = itemList.Find(x => x.Id == request.Id);
            existItem.Name = request.Name;
            existItem.Quantity = request.Quantity;
           
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var itemList = DummyData.Products;

            var indexNumber = itemList.FindIndex(x => x.Id == id);
            itemList.RemoveAt(indexNumber);

            return NoContent();
        }
    }
}

namespace Test
{
    public class MvcCOntroller : Controller
    {
        // [HttpGet] => we have it as a defailt in MVC project
        public ActionResult Index()
        {
            var itemList = new List<Product>
            {
                new(){Id=1,Name="Brick",Quantity=55},
                new(){Id=2,Name="Cement",Quantity=155},
                new(){Id=3,Name="Nails",Quantity=255},

            };
            return View(itemList);
        }
        [HttpPost]
        public ActionResult Index(int p)
        {
            var itemList = new List<Product>
            {
                new(){Id=1,Name="Brick",Quantity=55},
                new(){Id=2,Name="Cement",Quantity=155},
                new(){Id=3,Name="Nails",Quantity=255},

            };
            return View(itemList);
        }
    }
}
