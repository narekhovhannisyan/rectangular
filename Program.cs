using System;

namespace square {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine ("a");
      int a = int.Parse (Console.ReadLine ());
      Console.WriteLine ("b");
      int b = int.Parse (Console.ReadLine ());
      Console.WriteLine ("coords x");
      int x = int.Parse (Console.ReadLine ());
      Console.WriteLine ("coords y");
      int y = int.Parse (Console.ReadLine ());
      square (a, b, x, y);
    }

    public static void square (int a, int b, int x, int y) {
      int color = 0;
      Console.SetCursorPosition (x, y);
      for (int k = 0; k <= b; k++) {

        Console.WriteLine ();
        Console.CursorLeft = 10;
        for (int i = 0; i <= a; i++) {
          if (k == 0 || k == b) {
            Console.ForegroundColor = (ConsoleColor) (color++ % 15);
            Console.Write ("*");
          } else {
            if (i == 0 || i == a) {
              Console.ForegroundColor = (ConsoleColor) (color++ % 15);
              Console.Write ("*");
            } else {
              Console.Write (" ");
            }
          }
        }
      }
      Console.WriteLine();
    }
  }
}