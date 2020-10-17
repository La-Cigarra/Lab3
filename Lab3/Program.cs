using System;
using System.Diagnostics.SymbolStore;

namespace Lab3
{
    class Point
    {
        public int x;
        public int y;
        public string[] sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(string[] symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            for (int i = 0; i < sym.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(sym[i]);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            Console.Write("Введите значение x: ");
            p.x = Int32.Parse(Console.ReadLine());
            p.SetX(p.x);
            Console.Write("Введите значение y: ");
            p.y = Int32.Parse(Console.ReadLine());
            p.SetX(p.y);
            string[] arr = { "___", "***", "|||" }; // <==== Рисунок варианта.
            p.sym = arr;
            p.SetSym(p.sym);
            p.Draw();
            Console.ReadKey();
        }
    }
}
