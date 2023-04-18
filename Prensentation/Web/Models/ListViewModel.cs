using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;

namespace Web.Models
{
    public class ListViewModel
    {

        public string Url { get; set; }
        public IEnumerable<Article> articles { get; set; }
        public ListView Type { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

    }

}