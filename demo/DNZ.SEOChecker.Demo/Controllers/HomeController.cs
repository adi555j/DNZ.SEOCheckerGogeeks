using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DNZ.SEOChecker.Demo.Components;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace DNZ.SEOChecker.Demo.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync("https://www.gogeeks.in/Details/2/AMD-Ryzen-3-3200G-Processor-with-Radeon-RX-Vega-8-Graphics-(4-Cores-4-Threads-with-Max-Boost-Clock-of-up-to-4GHz,-Base-Clock-of-3.6GHz,-AM4-Socket-and-6MB-Cache-Memory)");

            var htmlDoc = new HtmlDocument() { OptionFixNestedTags = true };
            htmlDoc.LoadHtml(html);
            var content = htmlDoc.GetElementbyId("content").InnerHtml;

            var seoInput = new SeoInput
            {
                Title = "Search Engine Optimization",
                Url = "Search_Engine_Optimization",
                Keyword = "SEO",
                MetaDescription = "Search Engine Optimization (SEO), abbreviated as SEO, is a suitable process for enhancing the visibility of a website or a web page in the organic search results of a search engine.",
                Text = content
            };
            return View(seoInput);
        }
    }
}
