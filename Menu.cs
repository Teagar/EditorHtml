using System;

namespace EditorHtml
{

  public static class Menu
  {

    public static void Show()
    {

      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;
      DrawScreen();
    }

    public static void DrawScreen()
    {
      
      BuildCanvas(30, 15);
    }

    public static void BuildCanvas(int x, int y, char separator = '+', char line = '-', char column = '|')
    {

      void BuildX()
      {

        Console.Write(separator);
        for (int i = 0; i < x; i++) {

          Console.Write(line);
        }
        Console.Write($"{separator}\n");
      }

      void BuildY()
      {

        for (int i = 0; i < y; i++) {

          Console.Write(column);
          for (int j = 0; j < x; j++) {

            Console.Write(" ");
          }
          Console.Write($"{column}\n");
        }
      }

      BuildX();
      BuildY();
      BuildX();
    }

  }
}

