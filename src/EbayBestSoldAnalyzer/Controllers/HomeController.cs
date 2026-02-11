using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EbayBestSoldAnalyzer.Models;

namespace EbayBestSoldAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Items(string url)
        {
            url = url + "&_ipg=200";

            Analyzer an = new Analyzer();

           var items = await an.Run(url);

            List<ItemDto> result = new List<ItemDto>();

            foreach (var item in items.OrderByDescending(it=>it.Count))
            {
                result.Add(new ItemDto(item));
            }


            return View(result);
        }

    }
}
