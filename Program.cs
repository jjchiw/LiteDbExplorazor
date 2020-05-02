using System;
using WebWindows.Blazor;

namespace LiteDbExplorazor
{
  class Program
  {
    static void Main(string[] args)
    {
      ComponentsDesktop.Run<Startup>("LiteDbExplorazor", "wwwroot/index.html");
    }
  }
}
