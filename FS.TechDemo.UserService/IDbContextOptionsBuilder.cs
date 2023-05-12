using FS.Common.DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace UserAuthorizationService;

public interface IDbContextOptionsBuilder : IConnectionStringSetter
{
    void BuildOptions(DbContextOptionsBuilder options);
}

public abstract class S4HDbContextOptionsBuilderBase : ConnectionStringSetter, IDbContextOptionsBuilder
{
    public abstract void BuildOptions(DbContextOptionsBuilder options);
}
