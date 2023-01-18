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
    public class DetailsModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public DetailsModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

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
    }
}
