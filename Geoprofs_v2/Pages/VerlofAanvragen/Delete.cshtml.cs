using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoProfs.Data;
using Geoprofs_v2.Models;

namespace Geoprofs_v2.Pages.VerlofAanvragen
{
    public class DeleteModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public DeleteModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VerlofAanvraag VerlofAanvraag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VerlofAanvraag = await _context.VerlofAanvraag.FirstOrDefaultAsync(m => m.verlof_id == id);

            if (VerlofAanvraag == null)
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

            VerlofAanvraag = await _context.VerlofAanvraag.FindAsync(id);

            if (VerlofAanvraag != null)
            {
                _context.VerlofAanvraag.Remove(VerlofAanvraag);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
