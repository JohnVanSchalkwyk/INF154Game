using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class Primary
    {
        static void Main(string[] args)
        {
            drawInterface draw = new drawInterface();
            draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 55, 0);
            draw.drawResourceMatrix(7, 7, 7);
     

        }
    }
}
