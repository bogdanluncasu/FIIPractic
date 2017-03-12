using Microsoft.EntityFrameworkCore;

namespace FiiPractic.Data.Infrastructure
{
  public interface IDatabaseFactory
  {
    DbContext Get();
  }

}
