using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HTMLPreviewWeb.Data;
using HTMLPreviewWeb.Models;

namespace HTMLPreviewWeb.Pages.HTML_Editor
{
    public class DeleteModel : PageModel
    {
        private readonly HTMLPreviewWeb.Data.HTMLPreviewWebContext _context;

        public DeleteModel(HTMLPreviewWeb.Data.HTMLPreviewWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HTMLContent HTMLContent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HTMLContent = await _context.HTMLContent.FirstOrDefaultAsync(m => m.ID == id);

            if (HTMLContent == null)
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

            HTMLContent = await _context.HTMLContent.FindAsync(id);

            if (HTMLContent != null)
            {
                _context.HTMLContent.Remove(HTMLContent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
