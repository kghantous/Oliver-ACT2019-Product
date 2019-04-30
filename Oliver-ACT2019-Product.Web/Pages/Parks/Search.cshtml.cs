using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oliver_ACT2019_Product.Web.Models;

namespace Oliver_ACT2019_Product.Web.Pages.Parks
{
    public class SearchModel : PageModel
    {
        [BindProperty]
        public string Query { get; set; }

        public IEnumerable<Park> Results { get; set; } 

        public void OnGet()
        {
            //Load the search Page!
        }

        public async Task OnPost([FromServices] NPPDbContext context)
        {
            Results = await context.Parks.Where(row => row.Name.StartsWith(Query)).ToListAsync();
        }
    }
}