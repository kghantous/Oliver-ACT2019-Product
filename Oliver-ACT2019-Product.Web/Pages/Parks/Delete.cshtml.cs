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
    public class DeleteModel : PageModel
    {
        private readonly Oliver_ACT2019_Product.Web.Models.NPPDbContext _context;

        public DeleteModel(Oliver_ACT2019_Product.Web.Models.NPPDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Park Park { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Park = await _context.Parks.FirstOrDefaultAsync(m => m.Id == id);

            if (Park == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Park = await _context.Parks.FindAsync(id);

            if (Park != null)
            {
                _context.Parks.Remove(Park);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
