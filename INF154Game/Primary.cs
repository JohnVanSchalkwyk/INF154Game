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
            drawInterface draw = new drawInterface(); // PLease help me fix the intro to the right side :)
            raceDescription describe_Race = new raceDescription();
            userCom firstContact = new userCom();
            setCursor cursor = new setCursor();

            draw.setConoleSize();
            draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 5, 0);
            draw.drawResourceMatrix(7, 7, 7);
            cursor.WriteAt("*",40,0);
            //describe_Race.describeHuman();
            //describe_Race.describeOrc();
            //describe_Race.describeElf();
            //describe_Race.describeCyborg();

            
            //cursor.WriteAt("", 40, 0); 
            //firstContact.welcomeMessage();
            

        }
    }
}
