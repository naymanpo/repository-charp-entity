using System.Data.Entity;
using resposity_enity_csharp.Models;
using resposity_enity_csharp.Query.Core.Repositories;

namespace resposity_enity_csharp.Query.Persistence
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {
        }
    }
}