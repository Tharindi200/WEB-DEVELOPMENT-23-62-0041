using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITCourseManagerApp.Data;
using ITCourseManagerApp.Model;

namespace ITCourseManagerApp.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly ITCourseManagerApp.Data.ITCourseManagerAppContext _context;

        public IndexModel(ITCourseManagerApp.Data.ITCourseManagerAppContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Students = await _context.Student.ToListAsync();
            }
        }
    }
}
