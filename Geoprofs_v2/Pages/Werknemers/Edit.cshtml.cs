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

namespace Geoprofs_v2.Pages.Werknemers
{
    public class EditModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public EditModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Werknemer Werknemer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Werknemer = await _context.Werknemers.FirstOrDefaultAsync(m => m.werknemer_id == id);

            if (Werknemer == null)
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

            _context.Attach(Werknemer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WerknemerExists(Werknemer.werknemer_id))
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

        private bool WerknemerExists(int id)
        {
            return _context.Werknemers.Any(e => e.werknemer_id == id);
        }
    }
}
