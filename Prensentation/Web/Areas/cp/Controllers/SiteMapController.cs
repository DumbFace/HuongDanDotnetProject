using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CMS.Core.Domain;
using CMS.Service.ArticleService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Factory;
using CMS.Core.Helper;
namespace Web.Areas.cp.Controllers
{
    [Area("cp")]
    public class SiteMapController : Controller
    {
        private readonly ILogger<SiteMapController> _logger;
        private readonly IContentFactory _content;
        public SiteMapController(
            ILogger<SiteMapController> logger,
            IContentFactory content
        )
        {
            _content = content;
            _logger = logger;
        }

        public IActionResult Index()
        {
            GenerateSitemap(_content.GetSiteMap());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


        public void GenerateSitemap(IEnumerable<ArticleViewModel> articles)
        {
            string strPhysical = Constrants.RootPath + "\\wwwroot" + "\\sitemap.xml";

            using (XmlTextWriter writer = new XmlTextWriter(strPhysical, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartDocument();
                writer.WriteStartElement("urlset");
                writer.WriteAttributeString("xmlns", "http://www.sitemaps.org/schemas/sitemap/0.9");
                writer.WriteStartElement("url");
                writer.WriteElementString("loc", "https://phamphuongkhang.xyz/");
                writer.WriteElementString("lastmod", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:00+07:00"));
                writer.WriteElementString("changefreq", "hourly");
                writer.WriteElementString("priority", "1.00");
                writer.WriteEndElement(); // end of url

                foreach (ArticleViewModel item in articles)
                {
                    writer.WriteStartElement("url");
                    writer.WriteElementString("loc", item.FriendLyUrl);
                    writer.WriteElementString("lastmod", item.DateSiteMap);
                    writer.WriteElementString("changefreq", "hourly");
                    writer.WriteElementString("priority", "0.80");
                    writer.WriteEndElement();  //end url
                }
                writer.WriteEndElement(); // end of urlset
                writer.WriteEndDocument();
                writer.Close();

                // code to write the sitemap goes here
            }


        }
    }


}