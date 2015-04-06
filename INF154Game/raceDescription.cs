using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class raceDescription
    {
        setCursor cursor = new setCursor();
        public void describeHuman()
        {
            //==================================================================================================
            //      Banner Creation
            cursor.WriteAt("", 42, 0);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 1);
            Console.WriteLine("\t\tTHE HUMANS - IN EACH OTHER WE TRUST");
            cursor.WriteAt("", 42, 2);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 3);

            //==================================================================================================
            //      Description of Race

            Console.WriteLine("Under the leadership of General [INSERT NAME HERE] the Human race has");
            cursor.WriteAt("", 42, 4);
            Console.WriteLine("evolved into a mighty force not to be reckoned with.");
            cursor.WriteAt("\n", 42, 5);
            cursor.WriteAt("", 42, 6);
            Console.WriteLine("With a large emphasis places on the importance of teamwork, the Humans");
            cursor.WriteAt("", 42, 7);
            Console.WriteLine("have an advantage with the generation of Labor Points.");
            cursor.WriteAt("\n", 42, 8);
            cursor.WriteAt("", 42, 9);
            Console.WriteLine("For as long as can be remembered the Humans have been present no the ");
            cursor.WriteAt("", 42, 10);
            Console.WriteLine("planet Earth, and due to evolving their civilization on this planet,");
            cursor.WriteAt("", 42, 11);
            Console.WriteLine("they have developed methods to survive the harsh terrain.");
            cursor.WriteAt("\n", 42, 12);
            cursor.WriteAt("", 42, 13);
            Console.WriteLine("With this evolutionary advance they suffer no penalty upon staring the game.");
            cursor.WriteAt("", 42, 14);
            Console.WriteLine("----------------------------------------------------------------------------");
          
         
            cursor.WriteAt("", 42, 19);
            Console.WriteLine("                                /                                  ");
            cursor.WriteAt("", 42, 20);
            Console.WriteLine("                             ,-/ / / -,                                  ");
            cursor.WriteAt("", 42, 21);
            Console.WriteLine("                          ,`  / / / /  `,                                   ");
            cursor.WriteAt("", 42, 22);
            Console.WriteLine("                         /     / / /                                        ");
            cursor.WriteAt("", 42, 23);
            Console.WriteLine("                        ,=_     / /    _=,                                  ");
            cursor.WriteAt("", 42, 24);
            Console.WriteLine("                        |  '_    /   _'  |                                  ");
            cursor.WriteAt("", 42, 25);
            Console.WriteLine("                        |_   ''-..-''   _|                                  ");
            cursor.WriteAt("", 42, 26);
            Console.WriteLine("                        | '-.        .-' |                                  ");
            cursor.WriteAt("", 42, 27);
            Console.WriteLine("                        |    '     /'    |                                  ");
            cursor.WriteAt("", 42, 28);
            Console.WriteLine("                        |      |  |      |                                  ");
            cursor.WriteAt("", 42, 29);
            Console.WriteLine("                        '_     |  |     _'                                  ");
            cursor.WriteAt("", 42, 30);
            Console.WriteLine("                         -'-.  |  |  .-'-                                   ");
            cursor.WriteAt("", 42, 31);
            //=================================================================================================
        }
        public void describeOrc()
        {
            //==================================================================================================
            //      Banner Creation
            cursor.WriteAt("", 42, 0);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 1);
            Console.WriteLine("\t\tTHE ORCS - IN MASSES WE OVERWHELM");
            cursor.WriteAt("", 42, 2);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 3);

            //==================================================================================================
            //      Description of Race
            //Console.WriteLine("");
            Console.WriteLine("Goblin Lord Eshrach rules the Orcish Empire with an iron fist. His warriors");
            cursor.WriteAt("", 42, 4);
            Console.WriteLine("are trained in the art of swarm warfare and they fear no rival.");
            cursor.WriteAt("\n", 42, 5);
            cursor.WriteAt("", 42, 6);
            Console.WriteLine("Their entire goal is to grow in numbers as fast as possible and therefore");
            cursor.WriteAt("", 42, 7);
            Console.WriteLine("receive a 30% reduction in the hunger level pool for each house constructed.");
            cursor.WriteAt("\n", 42, 8);
            cursor.WriteAt("", 42, 9);
            Console.WriteLine("This rapid growing swarm has its downfalls which results into a 15%");
            cursor.WriteAt("", 42, 10);
            Console.WriteLine("labour point reduction due to mismanagement of resources.");
            cursor.WriteAt("\n", 42, 5);
            cursor.WriteAt("", 42, 11);
            Console.WriteLine("If you are enduring and have a strategic tactic, you will soon be able to");
            cursor.WriteAt("", 42, 12);
            Console.WriteLine("conquer any rival with utter supremacy.");
            cursor.WriteAt("", 42, 13);
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
        public void describeElf()
        {
            //==================================================================================================
            //      Banner Creation
            cursor.WriteAt("", 42, 0);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 1);
            Console.WriteLine("\t\tTHE ELVES - THROUGH GAIA WE GROW");
            cursor.WriteAt("", 42, 2);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 3);
            //==================================================================================================
            //      Description of Race

            Console.WriteLine("The sun is our heart and the moon our soul. Through the guidance of Gaia we ");
            cursor.WriteAt("", 42, 4);
            Console.WriteLine("thrive to become one with nature and allow it to be out weapon.");
            cursor.WriteAt("\n", 42, 5);
            cursor.WriteAt("", 42, 6);
            Console.WriteLine("While following the laws of nature we have to be patient and nursing to ");
            cursor.WriteAt("", 42, 7);
            Console.WriteLine("ensure the growth of Gaia’s life force within our buildings, as a result ");
            cursor.WriteAt("", 42, 8);
            Console.WriteLine("buildings demand more labor points.");
            cursor.WriteAt("\n", 42, 9);
            cursor.WriteAt("", 42, 10);
            Console.WriteLine("Nature supports us in our cause and provides extra sustenance for our ");
            cursor.WriteAt("", 42, 11);
            Console.WriteLine("worriers. As a result only half of our buildings are takes into consideration ");
            cursor.WriteAt("", 42, 12);
            Console.WriteLine("for our hunger passions.");
            cursor.WriteAt("\n", 42, 13);
            cursor.WriteAt("", 42, 14);
            Console.WriteLine("Be a warrior of nature and let our goddess Gaia do all the heavy lifting");
            cursor.WriteAt("", 42, 15);
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
        public void describeCyborg()
        {
            //==================================================================================================
            //      Banner Creation
            cursor.WriteAt("", 42, 0);    
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 1);
            Console.WriteLine("\t\tTHE CYBORGS - IN MASSES WE OVERWHELM");
            cursor.WriteAt("", 42, 2);
            Console.WriteLine("----------------------------------------------------------------------------");
            cursor.WriteAt("", 42, 3);
            //==================================================================================================
            //      Description of Race

            Console.WriteLine("Technology is always improving and no natural element can stand in our way. ");
            cursor.WriteAt("", 42, 4);
            Console.WriteLine("We are all parts of an evolving and interconnected machine with a hive mind.");
            cursor.WriteAt("", 42, 5);
            Console.WriteLine("Our leader Quentrona is within each of every one of us, she thinks for us, ");
            cursor.WriteAt("", 42, 6);
            Console.WriteLine("listens to us and protects us.");
            cursor.WriteAt("\n", 42, 7);
            cursor.WriteAt("", 42, 8);
            Console.WriteLine("We are technological beings and thus have the ability to calculate the best ");
            cursor.WriteAt("", 42, 9);
            Console.WriteLine("actions for every situation and thus can construct buildings with half the ");
            cursor.WriteAt("", 42, 10);
            Console.WriteLine("number of manpower needed.");
            cursor.WriteAt("\n", 42, 11);
            cursor.WriteAt("", 42, 12);
            Console.WriteLine("Our superior intellect allows us to wore wisely and construct buildings with ");
            cursor.WriteAt("", 42, 13);
            Console.WriteLine("less resources as normal. Choose us if you want Quentrona to solve your ");
            cursor.WriteAt("", 42, 14);
            Console.WriteLine("problems for you.");
            cursor.WriteAt("", 42, 15);
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
    }
}
