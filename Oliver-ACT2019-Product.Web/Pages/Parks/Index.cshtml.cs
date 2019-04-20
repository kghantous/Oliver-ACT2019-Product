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
    public class IndexModel : PageModel
    {
        private readonly Oliver_ACT2019_Product.Web.Models.NPPDbContext _context;

        public IndexModel(Oliver_ACT2019_Product.Web.Models.NPPDbContext context)
        {
            _context = context;
        }

        public IList<Park> Park { get;set; }
        public Dictionary<int,string> StateLookup { get; set; }

        public async Task OnGetAsync()
        {
            Park = await _context.Parks.ToListAsync();
            StateLookup = await _context.States.ToDictionaryAsync(x => x.Id, x => x.Name);
        }
    }
}
