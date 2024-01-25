using System;
using System.Text;

namespace EditorHtml
{

  public static class Editor
  {

    public static void View()
    {

      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Menu.BuildCanvas(35, 12);
      EditMode();
      Initialize();
    }

    public static void Initialize()
    {

      var file = new StringBuilder();

      do {

        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("--------------------------");
      Console.WriteLine("  Do U want save the archive? [y/n]");
    }

    public static void EditMode()
    {

      Console.SetCursorPosition(10, 2);
      Console.Write("Edit Mode (<Esc> to exit)");
      Console.SetCursorPosition(6, 3);
      Console.Write("-------------------");

      Console.SetCursorPosition(3, 5);
    }
  }
}

