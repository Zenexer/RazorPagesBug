using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test1Model : PageModel
    {
        [BindProperty(SupportsGet = true)] public string Id { get; set; } = "default";
        [BindProperty(SupportsGet = true)] public new string Page { get; set; } = "default";

        public void OnGet()
        {

        }
    }
}