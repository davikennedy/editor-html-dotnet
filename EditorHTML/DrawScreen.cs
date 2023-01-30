using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Screen
    {
        public static void Draw()
        {
            CreateLines();
            CreateColumns();
            CreateLines();
        }

        private static void CreateLines()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+\n");
        }

        private static void CreateColumns()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|\n");
            }
        }
    }
}
