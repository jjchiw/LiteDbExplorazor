using LiteDB;
using Microsoft.Extensions.Options;

namespace LiteDbExplorazor.LiteDb
{
  public interface ILiteDbContext
  {
    LiteDatabase Database { get; }
  }
  public class LiteDbContext : ILiteDbContext
  {
    public LiteDatabase Database { get; }
    public LiteDbContext()
    {
      Database = new LiteDatabase("Db/DlmSharpDb.db");
    }
  }
}
