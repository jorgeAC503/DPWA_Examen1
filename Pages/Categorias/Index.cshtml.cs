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

namespace PrimerExamen.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly PrimerExamen.Data.PrimerExamenContext _context;

        public IndexModel(PrimerExamen.Data.PrimerExamenContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

       // public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Nombre { get; set; }

        public async Task OnGetAsync()
        {
            var Categorias = from m in _context.Category
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Categorias = Categorias.Where(s => s.CategoryName.Contains(SearchString));
            }

            Category = await Categorias.ToListAsync();
        }
    }
}
