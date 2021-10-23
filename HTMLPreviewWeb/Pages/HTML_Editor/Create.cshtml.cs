using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HTMLPreviewWeb.Data;
using HTMLPreviewWeb.Models;

namespace HTMLPreviewWeb.Pages.HTML_Editor
{
    public class CreateModel : PageModel
    {
        private readonly HTMLPreviewWeb.Data.HTMLPreviewWebContext _context;

        public CreateModel(HTMLPreviewWeb.Data.HTMLPreviewWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HTMLContent HTMLContent { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HTMLContent.Add(HTMLContent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
