using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class userCom
    {
        public void welcomeMessage()
        {
            setCursor cursor = new setCursor();
            string welcome = "Welcome to INF 154";
            int stringSize = welcome.Length;
            typeWriterEffect(welcome, stringSize);

            
            welcome = "Are you ready for an experience of your life?";
            stringSize = welcome.Length;
            typeWriterEffectReverse(welcome, stringSize);
            cursor.WriteAt("", 0, 3);
            welcome = "Let's begin with the formalities shall we...";
            stringSize = welcome.Length;
            Console.WriteLine();
            typeWriterEffect(welcome, stringSize);
            cursor.WriteAt("",5,3);
            welcome = "In the beginning there was a town, a town in ruins.";
            stringSize = welcome.Length;
            typeWriterEffect(welcome, stringSize);
            cursor.WriteAt("", 5, 5);
            welcome = "Shattered by civil war and broken by rival factions.";
            stringSize = welcome.Length;
            typeWriterEffect(welcome, stringSize);



            
            


        }
        public string promptChoice()
        {
            setCursor b = new setCursor();
            b.WriteAt("Select your race (Human, Orc, Elve and Cyborg)\n",5,2);
            
            
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            setRace a = new setRace();
            string final = a.selectRace(choice);
            return final;

        }
        public void typeWriterEffect(string a, int b)
        {
           

            for (int i = 0; i < b; i++)
            {
                Console.Write(a[i]);
                System.Threading.
                Thread.Sleep(100);

            }
        }
            public void typeWriterEffectReverse(string a, int b)
        {
            setCursor cursor = new setCursor();
            int col = (b-1);
            
            for (int i = b-1; i >= 0; i--)
            {
                cursor.WriteAt("", col,0); //Setting the console to start at the end of the column and work its way forward
                col--;
                
                Console.Write(a[i]);
                System.Threading.
                Thread.Sleep(100);

            }
            Console.WriteLine();

         
      

        }

        
    }

}
