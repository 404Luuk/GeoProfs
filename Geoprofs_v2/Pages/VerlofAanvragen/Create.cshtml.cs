using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GeoProfs.Data;
using Geoprofs_v2.Models;

namespace Geoprofs_v2.Pages.VerlofAanvragen
{
    public class CreateModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public CreateModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VerlofAanvraag VerlofAanvraag { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VerlofAanvraag.Add(VerlofAanvraag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
