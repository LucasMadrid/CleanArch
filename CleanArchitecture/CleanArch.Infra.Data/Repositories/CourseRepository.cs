using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
