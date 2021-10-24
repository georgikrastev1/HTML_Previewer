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
    public class IndexModel : PageModel
    {
        private readonly HTMLPreviewWeb.Data.HTMLPreviewWebContext _context;

        public IndexModel(HTMLPreviewWeb.Data.HTMLPreviewWebContext context)
        {
            _context = context;
        }

        public IList<HTMLContent> HTMLContent { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public async Task OnGetAsync()
        {
            //HTMLContent = await _context.HTMLContent.ToListAsync();

            var htmlcontent = from m in _context.HTMLContent
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                htmlcontent = htmlcontent.Where(s => s.Content.Contains(SearchString));
            }

            HTMLContent = await htmlcontent.ToListAsync();
        }
    }
}
