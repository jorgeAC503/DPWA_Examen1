﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly PrimerExamen.Data.PrimerExamenContext _context;

        public DeleteModel(PrimerExamen.Data.PrimerExamenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Login Login { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FirstOrDefaultAsync(m => m.ID == id);

            if (login == null)
            {
                return NotFound();
            }
            else
            {
                Login = login;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FindAsync(id);
            if (login != null)
            {
                Login = login;
                _context.Login.Remove(Login);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
