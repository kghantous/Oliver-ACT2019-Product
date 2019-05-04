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
        [BindProperty(SupportsGet =true)]
        public string Query { get; set; }

        public IEnumerable<Park> Results { get; set; } 

        public async Task OnGetAsync([FromServices] NPPDbContext context)
        {
            if(string.IsNullOrWhiteSpace(Query))
            {
                await Task.CompletedTask;
            }

            //Load the search Page!
            Results = await context.Parks
                .Where(row => row.Name.StartsWith(Query))
                .OrderBy(x=>x.Name)
                .ToListAsync();

        }

       
    }
}