using ApiProject.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {
            var itemList = DummyData.Products;

            var response = CustomResponseModel<List<Product>>.Success(itemList, 200);

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            var itemList = DummyData.Products;
            var infexFind = itemList.FindIndex(x => x.Id == id);
            var response = new CustomResponseModel<Product>();

            if (infexFind < 0)
            {
                response = CustomResponseModel<Product>.Fail(404, "user not found");
            }

            else
            {
                var item = itemList[infexFind];

                response = CustomResponseModel<Product>.Success(item, 200);

            }
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }
    }
}
