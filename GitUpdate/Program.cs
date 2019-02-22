using System;

namespace GitUpdate
{
  using System.IO;

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

      string gitUpdateCommand = $"Git add *{Environment.NewLine}";

      // then git commit
      gitUpdateCommand += $"git commit -m \"{message}\"{Environment.NewLine}";

      // then git push origin master
      gitUpdateCommand += $"git push origin master{Environment.NewLine}";


      display("press any key to exit:");
      Console.ReadKey();
    }

    private void AddPauseToFile(string fileName)
    {
      const bool append = true;
      var sw = new StreamWriter(fileName, append);
      sw.WriteLine(string.Empty);
      sw.WriteLine("REM Press a key to exit");
      sw.WriteLine("pause");
      sw.Close();
    }
  }
}