using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class updateInterface
    {
       public void interFace()
    {

        

    }
        public void welcomeMessage()
        {
          
            Console.WriteLine("Welcome to INF154 game ");
            

        }
        public string promptChoice()
        {
            Console.WriteLine("Select your race (Human, Orc, Elve and Cyborg)");
            string choice = Console.ReadLine();
            setRace a = new setRace();
            string final = a.selectRace(choice);
            return final;

        }
        
        
        
    }
}
