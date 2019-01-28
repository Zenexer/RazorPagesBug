using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test9Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [BindProperty(SupportsGet = true, Name = "id")]   public string Id { get; set; } = "default";
            [BindProperty(SupportsGet = true, Name = "page")] public string Page { get; set; } = "default";
        }

        public void OnGet()
        {
        }
    }
}