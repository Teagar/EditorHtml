using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
  
  public static class Viewer
  {

    public static void View()
    {

      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Menu.BuildCanvas(35, 12);
      ViewerMode("");
      // Initialize();
    }

    public static void ViewerMode(string text)
    {

      Console.SetCursorPosition(10, 2);
      Console.Write("Viewer Mode");
      Console.SetCursorPosition(6, 3);
      Console.Write("-------------------");
      Replace(text);
      Console.Write("-------------------");
      Console.ReadKey();
      Menu.Show();

      Console.SetCursorPosition(3, 5);
    }

    public static void Replace(string text)
    {

      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');

      for (int i = 0; i < words.Length; i++) {

        if (strong.IsMatch(words[i]))
        {

          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(
              words[i].Substring(
                words[i].IndexOf('>') + 1,
                (
                 words[i].LastIndexOf('<') - 1) -
                words[i].IndexOf('>')
                )
              );
          Console.Write(" ");
        } else {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}

