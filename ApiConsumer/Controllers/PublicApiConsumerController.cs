using ApiConsumer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiConsumer.Controllers
{
    public class PublicApiConsumerController : Controller
    {
        public async Task<IActionResult> Index(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync($"https://api.guildwars2.com/v2/items/{id}");

            var content = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<GuildWarsItems>(content);

            return View(model);
        }
    }
}
