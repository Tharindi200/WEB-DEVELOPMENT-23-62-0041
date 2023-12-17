using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITCourseManagerApp.Data;
using ITCourseManagerApp.Model;

namespace ITCourseManagerApp.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly ITCourseManagerApp.Data.ITCourseManagerAppContext _context;

        public CreateModel(ITCourseManagerApp.Data.ITCourseManagerAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Courses Courses { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Course == null || Courses == null)
            {
                return Page();
            }

            _context.Course.Add(Courses);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
