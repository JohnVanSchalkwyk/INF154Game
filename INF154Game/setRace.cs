using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class setRace
    {
        setCursor cursor = new setCursor();
        private string setHuman()
        {
            return "Human";
          

        }
        private string setOrc()
        {
            return "Orc";
   
        }
        private string setCyborg()
        {
            return "Cyborg";
         
        }
        private string setElves()
        {
            return "Elf";
        }
       public string selectRace(string userRace)
        {
            string race = " ";
            userRace = userRace.ToUpper();
           if(userRace == "HUMAN")
           {
               race = setHuman();
               
           }
           else if(userRace == "ORC")
           {
               race = setOrc();
           

           }
           else if(userRace == "CYBORG")
           {
               race = setCyborg();
               
           }
           else if(userRace == "ELF")
           {
               race = setElves();
             
           }
           else
           {
               Console.WriteLine("Error, your race doesn't exist in this game.");
           }
           return race;
           
       }



  }
        
}
