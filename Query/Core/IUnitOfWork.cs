using System;
using resposity_enity_csharp.Query.Core.Repositories;

namespace resposity_enity_csharp.Query.Core
{
    public interface IUnitOfWork : IDisposable
    {
         ICourceRepository Courses{ get;}
         int Complete();
    }
}