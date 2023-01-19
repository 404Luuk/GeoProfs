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
    public class ManagerModel : PageModel
    {
        private readonly GeoProfs.Data.GeoprofsContext _context;

        public ManagerModel(GeoProfs.Data.GeoprofsContext context)
        {
            _context = context;
        }

        public IList<VerlofAanvraag> VerlofAanvraag { get;set; }

        public async Task OnGetAsync()
        {
            VerlofAanvraag = await _context.VerlofAanvraag.ToListAsync();
        }
    }
}
