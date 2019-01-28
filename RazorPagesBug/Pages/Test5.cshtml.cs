using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBug.Pages
{
    public class Test5Model : PageModel
    {
        [FromQuery(Name = "id")]   public string Id { get; set; } = "default";
        [FromQuery(Name = "page")] public new string Page { get; set; } = "default";

        public void OnGet()
        {
        }
    }
}