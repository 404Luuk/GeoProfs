using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoProfs.Data;
using Geoprofs_v2.Models;

namespace Geoprofs_v2.Pages.Werknemers
{
    public class DetailsModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public DetailsModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        public Werknemer Werknemer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Werknemer = await _context.Werknemers.FirstOrDefaultAsync(m => m.id == id);

            if (Werknemer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
