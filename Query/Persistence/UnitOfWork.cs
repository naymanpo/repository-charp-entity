using resposity_enity_csharp.Query.Core;
using resposity_enity_csharp.Query.Core.Repositories;

namespace resposity_enity_csharp.Query.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context){
            _context=context;
            Courses=new CourseRepository(_context);
        }
        public ICourceRepository Courses{ get; private set;}

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}