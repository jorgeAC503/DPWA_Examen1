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

namespace PrimerExamen.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly PrimerExamen.Data.PrimerExamenContext _context;

        public IndexModel(PrimerExamen.Data.PrimerExamenContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Nombre { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Product
                                            orderby m.CategoryID
                                            select m.CategoryID;

            var productos = from m in _context.Product
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                productos = productos.Where(s => 
                s.ProductName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(Category))
            {
                productos = productos.Where(x => x.CategoryID == Category);
            }
            Nombre = new SelectList(await genreQuery.Distinct().ToListAsync());

            Product = await productos.ToListAsync();
        }
    }
}
