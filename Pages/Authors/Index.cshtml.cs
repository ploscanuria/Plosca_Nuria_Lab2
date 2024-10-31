using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Plosca_nuria_lab2.Models;

namespace Plosca_nuria_lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Plosca_nuria_lab2.Data.Plosca_nuria_lab2Context _context;

        public IndexModel(Plosca_nuria_lab2.Data.Plosca_nuria_lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
