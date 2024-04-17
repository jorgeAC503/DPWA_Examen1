using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerExamen.Data;
using PrimerExamen.Models;

namespace PrimerExamen.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly PrimerExamen.Data.PrimerExamenContext _context;

        public IndexModel(PrimerExamen.Data.PrimerExamenContext context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Nombre { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Ciudad { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Supplier
                                            orderby m.City
                                            select m.City;

            var proveedores = from m in _context.Supplier
                            select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                proveedores = proveedores.Where(s =>
                s.CompanyName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(Ciudad))
            {
                proveedores = proveedores.Where(x => x.City == Ciudad);
            }
            Nombre = new SelectList(await genreQuery.Distinct().ToListAsync());

            Supplier = await proveedores.ToListAsync();
        }


    }
}
