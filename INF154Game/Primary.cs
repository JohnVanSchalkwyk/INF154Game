using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class Primary
    {
        static void Main(string[] args)
        {
            drawInterface draw = new drawInterface(); // PLease help me fix the intro to the right side :)
            raceDescription describe_Race = new raceDescription();
            userCom firstContact = new userCom();
            setCursor cursor = new setCursor();
            drawInterface setsize = new drawInterface();
            drawInterface intro = new drawInterface();

            setsize.setConsoleSize();
            bool continueSequence = intro.intro();

            if(continueSequence)
            {
                bool tutorial = intro.tutorialSelect();
                if(tutorial)
                {
                    draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 0, 0);
                    draw.drawResourceMatrix(0, 0, 0);
                    draw.tutorialDisplay();

                    draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 0, 0);
                    draw.drawResourceMatrix(0, 0, 0);

                }
                else
                {

                }
            }
            else
            {
               //Quit Game
            }
            //draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 0, 0);
            //draw.drawResourceMatrix(0, 0, 0);
            //describe_Race.describeHuman();


            
            /*//describe_Race.describeHuman();
            //describe_Race.describeOrc();
            describe_Race.describeElf();
            //describe_Race.describeCyborg();
            
            cursor.WriteAt("", 0, 0);
            draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 5, 0);
            draw.drawResourceMatrix(7, 7, 7);
            cursor.WriteAt("", 40, 0);
            cursor.WriteAt("", 100, 30); */
        
            

        }
    }
}
