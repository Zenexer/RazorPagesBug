using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test3Model : PageModel
    {
        public string Id { get; set; }
        public new string Page { get; set; }

        public void OnGet(string id = "default", string page = "default")
        {
            Id = id;
            Page = page;
        }
    }
}