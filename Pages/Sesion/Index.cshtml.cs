using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrimerExamen.Data;
using PrimerExamen.Models;

namespace PrimerExamen.Pages.Sesion
{
    public class IndexModel : PageModel
    {
        private readonly PrimerExamen.Data.PrimerExamenContext _context;

        public IndexModel(PrimerExamen.Data.PrimerExamenContext context)
        {
            _context = context;
        }

        public IList<Login> Login { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Login = await _context.Login.ToListAsync();
        }
    }
}
