using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class setCursor
    {
        protected  int origRow = 0;     //Co-ordinates of the screen
        protected  int origCol = 0;

        public void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y); // Set the cursor position IE - (column,row) -- We can jump back to column 1 
                                                                     // while staying at the same row position and vice versa.
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e) //In case the co-ordinates become out of bounds.
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}
