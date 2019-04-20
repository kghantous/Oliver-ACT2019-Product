using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Oliver_ACT2019_Product.Web.Models;

namespace Oliver_ACT2019_Product.Web.Pages.Parks
{
    public class CreateModel : PageModel
    {
        private readonly Oliver_ACT2019_Product.Web.Models.NPPDbContext _context;

        public CreateModel(Oliver_ACT2019_Product.Web.Models.NPPDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Park Park { get; set; }

        public SelectList StateLookup { get; set; }

        public async Task<IActionResult> OnGet()
        {
            //Get States
            StateLookup = new SelectList(await _context.States.OrderBy(x => x.Name).ToListAsync(), nameof(State.Id), nameof(State.Name));

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Parks.Add(Park);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}