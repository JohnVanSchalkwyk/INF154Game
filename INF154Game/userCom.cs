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
            string welcome = "Welcome to INF 154";
            int stringSize = welcome.Length;
            typeWriterEffect(welcome, stringSize);

            setCursor cursor = new setCursor();
            welcome = "Are you ready for an experience of your life?(Y/N)";
            stringSize = welcome.Length;
            cursor.WriteAt("", 0, 0);
            typeWriterEffectReverse(welcome, stringSize);

        }
        public string promptChoice()
        {
            Console.WriteLine("Select your race (Human, Orc, Elve and Cyborg)");
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
                cursor.WriteAt("", col,0);
                col--;
                
                Console.Write(a[i]);
                System.Threading.
                Thread.Sleep(100);

            }
            Console.WriteLine();

         
      

        }

        
    }

}
