using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test6Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Id { get; set; } = "default";
            public string Page { get; set; } = "default";
        }

        public void OnGet()
        {
        }
    }
}