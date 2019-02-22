using System;

namespace GitUpdate
{
  internal class Program
  {
    private static void Main(string[] arguments)
    {
      Action<string> display = Console.WriteLine;

      // TODO add cmd start process to
      // git add -m "update files"
      string message = "Update files";
      if (arguments.Length == 0)
      {
        message = arguments[0];
      }

      // then git commit
      // then git push origin master
      display("press any key to exit:");
      Console.ReadKey();
    }
  }
}