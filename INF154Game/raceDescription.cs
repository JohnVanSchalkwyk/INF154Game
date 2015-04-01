using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class raceDescription
    {
        public void describeHuman()
        {
            //==================================================================================================
            //      Banner Creation

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHE HUMANS - IN EACH OTHER WE TRUST");
            Console.WriteLine("----------------------------------------------------------------------------");

            //==================================================================================================
            //      Description of Race

            Console.WriteLine("\nUnder the leadership of General [INSERT NAME HERE] the Human race has\nevolved into a mighty force not to be reckoned with.");
            Console.WriteLine("\nWith a large emphasis places on the importance of teamwork, the Humans\nhave an advantage with the generation of Labor Points.");
            Console.WriteLine("\nFor as long as can be remembered the Humans have been present\non the planet Earth, " +
                                "and due to evolving their civilization on this planet,\nthey have developed methods to survive the harsh terrain. ");
            Console.WriteLine("\nWith this evolutionary advance they suffer no penalty upon staring the game.\n");
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
        public void describeOrc()
        {
            //==================================================================================================
            //      Banner Creation

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHE ORCS - IN MASSES WE OVERWHELM");
            Console.WriteLine("----------------------------------------------------------------------------");

            //==================================================================================================
            //      Description of Race

            Console.WriteLine("Goblin Lord Eshrach rules the Orcish Empire with an iron fist. His warriors \nare trained in the art of swarm warfare and they fear no rival.\n");
            Console.WriteLine("Their entire goal is to grow in numbers as fast as possible and therefore \nreceive a 30% reduction in the hunger level pool for each house constructed.\n");
            Console.WriteLine("This rapid growing swarm has its downfalls which results into a 15% \nlabour point reduction due to mismanagement of resources.\n");
            Console.WriteLine("If you are enduring and have a strategic tactic, you will soon be able to \nconquer any rival with utter supremacy.\n");
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
        public void describeElf()
        {
            //==================================================================================================
            //      Banner Creation

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHE ELVES - THROUGH GAIA WE GROW");
            Console.WriteLine("----------------------------------------------------------------------------");

            //==================================================================================================
            //      Description of Race

            Console.WriteLine("The sun is our heart and the moon our soul. Through the guidance of Gaia we \nthrive to become one with nature and allow it to be out weapon.\n");
            Console.WriteLine("While following the laws of nature we have to be patient and nursing to \nensure the growth of Gaia’s life force within our buildings, as a result \nbuildings demand more labor points.\n");
            Console.WriteLine("Nature supports us in our cause and provides extra sustenance for our \nworriers. As a result only half of our buildings are takes into consideration \nfor our hunger passions.\n");
            Console.WriteLine("Be a warrior of nature and let our goddess Gaia do all the heavy lifting\n");
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
        public void describeCyborg()
        {
            //==================================================================================================
            //      Banner Creation

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHE CYBORGS - IN MASSES WE OVERWHELM");
            Console.WriteLine("----------------------------------------------------------------------------");

            //==================================================================================================
            //      Description of Race

            Console.WriteLine("Technology is always improving and no natural element can stand in our way. \nWe are all parts of an evolving and interconnected machine with a hive mind.\n");
            Console.WriteLine("Our leader Quentrona is within each of every one of us, she thinks for us, \nlistens to us and protects us.\n");
            Console.WriteLine("We are technological beings and thus have the ability to calculate the best \nactions for every situation and thus can construct buildings with half the \nnumber of manpower needed.\n");
            Console.WriteLine("Our superior intellect allows us to wore wisely and construct buildings with \nless resources as normal. Choose us if you want Quentrona to solve your \nproblems for you.\n");
            Console.WriteLine("----------------------------------------------------------------------------");
            //==================================================================================================
        }
    }
}
