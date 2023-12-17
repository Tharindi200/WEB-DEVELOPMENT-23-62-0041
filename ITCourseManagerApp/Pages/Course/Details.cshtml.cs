using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITCourseManagerApp.Data;
using ITCourseManagerApp.Model;

namespace ITCourseManagerApp.Pages.Course
{
    public class DetailsModel : PageModel
    {
        private readonly ITCourseManagerApp.Data.ITCourseManagerAppContext _context;

        public DetailsModel(ITCourseManagerApp.Data.ITCourseManagerAppContext context)
        {
            _context = context;
        }

      public Courses Courses { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var courses = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);
            if (courses == null)
            {
                return NotFound();
            }
            else 
            {
                Courses = courses;
            }
            return Page();
        }
    }
}
