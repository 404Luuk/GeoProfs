using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GeoProfs.Data;
using GeoProfs.Models;

namespace GeoProfs.Pages.Students
{
    public class Verlof_redenModel : PageModel
    {
        private readonly GeoProfs.Data.SchoolContext _context;

        public Verlof_redenModel(GeoProfs.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Verlof_reden = new Verlof_reden { StartDate = DateTime.Now, FirstMidName = "Joe", LastName = "Smith" };
            return Page();
        }

        [BindProperty]
        public Verlof_reden Verlof_reden { get; set; }

        #region snippet_OnPostAsync
        public async Task<IActionResult> OnPostAsync()
        {
            #region snippet_TryUpdateModelAsync
            var emptyVerlof_reden = new Verlof_reden();

            if (await TryUpdateModelAsync<Verlof_reden>(
                emptyVerlof_reden,
                "Verlof_reden",   // Prefix for form value.
                s => s.FirstMidName, s => s.LastName, s => s.StartDate))
            {
                _context.Verlof_redens.Add(emptyVerlof_reden);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            #endregion

            return Page();
        }
        #endregion
    }
}