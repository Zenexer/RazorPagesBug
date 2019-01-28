using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test4Model : PageModel
    {
        public string Id { get; set; }
        public new string Page { get; set; }

        public void OnGet([FromQuery(Name = "id")] string id = "default", [FromQuery(Name = "page")] string page = "default")
        {
            Id = id;
            Page = page;
        }
    }
}