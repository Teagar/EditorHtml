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
      
      BuildCanvas(30, 12);
      WriteOptions();
      short option = 0;
      Int16.TryParse(Console.ReadLine(), out option);
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

    public static void WriteOptions()
    {

      Console.SetCursorPosition(10, 2);
      Console.Write("Editor HTML");
      Console.SetCursorPosition(6, 3);
      Console.Write("-------------------");

      Console.SetCursorPosition(3, 5);
      Console.Write("1 -\tOpen");
      Console.SetCursorPosition(3, 6);
      Console.Write("2 -\tEdit");
      Console.SetCursorPosition(3, 7);
      Console.Write("3 -\tWrite");
      Console.SetCursorPosition(3, 8);
      Console.Write("0 -\tExit");
      Console.SetCursorPosition(3, 9);
      Console.Write("--------------------------");

      Console.SetCursorPosition(3, 11);
      Console.Write("Option: ");
    }

  }
}

