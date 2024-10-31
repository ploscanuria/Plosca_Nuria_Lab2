﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Plosca_nuria_lab2.Data;
using Plosca_nuria_lab2.Models;

namespace Plosca_nuria_lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Plosca_nuria_lab2.Data.Plosca_nuria_lab2Context _context;

        public DetailsModel(Plosca_nuria_lab2.Data.Plosca_nuria_lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
