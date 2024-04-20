using ApiConsumer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ApiConsumer.Controllers
{
    public class ApiConsumerController : Controller
    {
        public async Task<IActionResult> GetAllProducts()
        {
            //method first
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:7253/api/home");
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<List<Product>>(content);

            //method second
            var newHttpClient = new HttpClient();
            var newModel = await httpClient.GetFromJsonAsync<List<Product>>("https://localhost:7253/api/home");

            return View(newModel);
        }
        [HttpGet]
        public async Task<IActionResult> ProductUpdate(int id)
        {
            //method first
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7253/api/home/{id}");
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Product>(content);

            //method second
            var newHttpClient = new HttpClient();
            var newModel = await newHttpClient.GetFromJsonAsync<Product>($"https://localhost:7253/api/home/{id}");


            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(Product request)
        {
            //method first
            //var httpClient = new HttpClient();           
            //var requestedString = JsonConvert.SerializeObject(request);
            //var requestedContent = new StringContent(requestedString,Encoding.UTF8,"application/json");
            //var response = await httpClient.PutAsync("https://localhost:7253/api/home", requestedContent);

            //method second
            var newHttpClient = new HttpClient();
            var newModel = await newHttpClient.PutAsJsonAsync<Product>("https://localhost:7253/api/home", request);

            return RedirectToAction(nameof(GetAllProducts));
        }

        [HttpGet]
        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(Product request)
        {
            //method first
            //var httpClient = new HttpClient();
            //var requestedString = JsonConvert.SerializeObject(request);
            //var requestedContent = new StringContent(requestedString, Encoding.UTF8, "application/json");
            //var response = await httpClient.PostAsync("https://localhost:7253/api/home", requestedContent);

            //method second
            var newHttpClient = new HttpClient();
            var newModel = await newHttpClient.PostAsJsonAsync("https://localhost:7253/api/home", request);


            return RedirectToAction(nameof(GetAllProducts));

        }

        public async Task<IActionResult> ProductDelete(int id)
        {
            //method first
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7253/api/home/{id}");


            return RedirectToAction(nameof(GetAllProducts));


        }

    }
}
