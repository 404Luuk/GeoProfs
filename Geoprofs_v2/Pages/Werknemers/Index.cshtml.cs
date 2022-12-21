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
    public class IndexModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public IndexModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        public IList<Werknemer> Werknemer { get;set; }

        public async Task OnGetAsync()
        {
            Werknemer = await _context.Werknemers.ToListAsync();
        }
    }
}
