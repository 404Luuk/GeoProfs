using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeoProfs.Data;
using Geoprofs_v2.Models;

namespace Geoprofs_v2.Pages.VerlofAanvragen
{
    public class EditModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public EditModel(GeoProfs.Data.GeoprofsContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VerlofAanvraag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerlofAanvraagExists(VerlofAanvraag.verlof_id))
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

        private bool VerlofAanvraagExists(int id)
        {
            return _context.VerlofAanvraag.Any(e => e.verlof_id == id);
        }
    }
}
