using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HTMLPreviewWeb.Data;
using HTMLPreviewWeb.Models;

namespace HTMLPreviewWeb.Pages.HTML_Editor
{
    public class EditModel : PageModel
    {
        private readonly HTMLPreviewWeb.Data.HTMLPreviewWebContext _context;

        public EditModel(HTMLPreviewWeb.Data.HTMLPreviewWebContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HTMLContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HTMLContentExists(HTMLContent.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HTMLContentExists(int id)
        {
            return _context.HTMLContent.Any(e => e.ID == id);
        }
    }
}
