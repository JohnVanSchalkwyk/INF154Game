using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class drawInterface
    {
       private int s_House_Building
                , m_House_Building
                , r_House_Building
                , tavern_Building
                , inn_Building
                , portal_Building
                , dna_Building
                , reasurch_Building
                , substinance_Building
                , total_Rounds
                , total_LP
                , total_Population;

        public drawInterface()
        {
            s_House_Building = 0;
            m_House_Building = 0;
            r_House_Building = 0;
            tavern_Building = 0;
            inn_Building = 0;
            portal_Building = 0; 
            dna_Building = 0;
            reasurch_Building = 0;
            substinance_Building = 0;
            total_Rounds = 0;
            total_LP = 0;
            total_Population = 0;
            
        }


        public void drawCollumm(int standardHouse_Number, int mediumHouse_Number, int royalHouse_Number,
           int tavern_Number, int inn_Number, int portal_Number, int dnaReplicator_Number, int research_Number, int substinance_Number)
        {
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine("\t     YOUR BUILDINGS             |");

            // Draw the coulumns
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Standard House       |     " + standardHouse_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Medium House         |     " + mediumHouse_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Royal House          |     " + royalHouse_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Tavern               |     " + tavern_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   INN                  |     " + inn_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Portal               |     " + portal_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   DNA Replicator       |     " + dnaReplicator_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Research Farm        |     " + research_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
            Console.WriteLine(" |   Substinance Centre   |     " + substinance_Number + "     |\t|");
            Console.WriteLine(" -------------------------------------- |");
        }

        public void drawResourceMatrix(int population, int labourPoints, int roundsTotal)
        {
            Console.WriteLine("\n --------------------------------------");
            Console.WriteLine(" |           YOUR RESOURCES           |");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" |   Population       |       " + population + "       |");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" |   Labor Points     |       " + labourPoints + "       |");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" |   Rounds           |       " + roundsTotal + "       |");
            Console.WriteLine(" --------------------------------------");
        }
    }

}
