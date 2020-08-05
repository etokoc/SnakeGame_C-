using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    class Program
    {
        public static int x = 0, y = 0;
        static void Main(string[] args)
        {
            //4,38
            frame();
            start_box(4, 38);
            while (true)
            {
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:

                        position_update(0, -2);
                        break;
                    case ConsoleKey.DownArrow:

                        position_update(0, 2);
                        break;
                    case ConsoleKey.RightArrow:

                        position_update(2, 0);
                        break;
                    case ConsoleKey.LeftArrow:

                        position_update(-2, 0);
                        break;
                }
            }
        }
        static private void frame()
        {
            string up_wall = "▓";
            for (int i = 0; i < 50; i++)
            {
                Console.Write(up_wall);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(up_wall);
                for (int a = 0; a < 50; a++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(up_wall);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(up_wall);
            }
        }
        static private void start_box(int X, int Y )
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.Write("           ");
            Console.SetCursorPosition(X, Y);
            string box = "■" ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(box);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("X=" + Console.CursorLeft + "Y=" + Console.CursorTop);
            Console.SetCursorPosition(X, Y);
        }
        static private void position_update(int X,int Y)
        {
            if (Console.CursorLeft>=0 && X != 0)
            {
                x = Console.CursorLeft + X;
                y = Console.CursorTop;
                start_box(x, y);
            }
            if (Console.CursorTop>=0 && Y !=0)
            {
                y = Console.CursorTop + Y;
                x = Console.CursorLeft;
                start_box(x, y);
            }
            if (51<Console.CursorLeft)
            {
                Console.Clear();
                Console.WriteLine("Yandın");
                Console.ReadLine();
            }
            else if (Console.CursorLeft<1)
            {
                Console.Clear();
                Console.WriteLine("Yandın");
                Console.ReadLine();
            }
            else if (Console.CursorTop<1)
            {
                Console.Clear();
                Console.WriteLine("Yandın");
                Console.ReadLine();
            }
            else if (Console.CursorTop > 39)
            {
                Console.Clear();
                Console.WriteLine("Yandın");
                Console.ReadLine();
            }

        }
    }
}
