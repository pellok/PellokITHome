using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PellokITHome.Data;
using PellokITHome.Models;

namespace PellokITHome.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly PellokITHome.Data.PellokITHomeContext _context;

        public IndexModel(PellokITHome.Data.PellokITHomeContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
