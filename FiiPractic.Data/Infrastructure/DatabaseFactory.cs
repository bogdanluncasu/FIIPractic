using Microsoft.EntityFrameworkCore;

namespace FiiPractic.Data.Infrastructure
{
  public class DatabaseFactory : IDatabaseFactory
  {
    private DbContext dataContext;

    public DbContext Get()
    {
      if (dataContext != null) return dataContext;
      dataContext = new CommerceContext();
      return dataContext;
    }

  }
}
