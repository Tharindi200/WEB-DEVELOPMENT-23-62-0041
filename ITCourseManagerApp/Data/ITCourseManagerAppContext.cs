using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITCourseManagerApp.Model;

namespace ITCourseManagerApp.Data
{
    public class ITCourseManagerAppContext : DbContext
    {
        public ITCourseManagerAppContext (DbContextOptions<ITCourseManagerAppContext> options)
            : base(options)
        {
        }

        public DbSet<ITCourseManagerApp.Model.Courses> Course { get; set; } = default!;

        public DbSet<ITCourseManagerApp.Model.Students>? Student { get; set; }
    }
}
