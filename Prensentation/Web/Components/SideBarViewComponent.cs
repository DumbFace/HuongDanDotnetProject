using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Factory;
using Web.Models;

namespace Web.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IContentFactory _content;
        public SideBarViewComponent(IContentFactory content)
        {
            _content = content;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}