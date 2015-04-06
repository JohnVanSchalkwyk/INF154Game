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
        public void typeWriterEffect(string a, int x,int y)
        {

            setCursor cursor = new setCursor();
            cursor.WriteAt("", x, y);
            int size = a.Length;

            for (int i = 0; i < size; i++)
            {
                
                Console.Write(a[i]);
                System.Threading.
                Thread.Sleep(100);

            }
        }
            public void typeWriterEffectReverse(string a, int x,int y)
        {
            setCursor cursor = new setCursor();
            int size = a.Length;
            int col = (x-1);
            
            for (int i = size; i >= 0; i--)
            {
                cursor.WriteAt("", col,y); //Setting the console to start at the end of the column and work its way forward
                col--;
                
                Console.Write(a[i]);
                System.Threading.
                Thread.Sleep(100);

            }
            Console.WriteLine();

         
      

        }

        
    }

}
