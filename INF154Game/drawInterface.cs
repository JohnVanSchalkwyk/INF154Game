using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    class drawInterface
    {
        protected int introPromptSizeFromStart = 42, introPromptSizeBounds = 108;
        protected int introCenteredBorderStart = 25, introCenterBorderBounds = 124;
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

        public void setConsoleSize() // Set the size of the console window to a fixed position and size.
        {
            int origWidth, width;
            int origHeight, height;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            width = 150;
            height = 37;
            Console.SetWindowSize(width, height);
        }

        public bool intro()
        {
            userCom typeEffect = new userCom();
            setCursor cursor = new setCursor();
            cursor.WriteAt("----------------------------------------------------------------------------------------------------\n", introCenteredBorderStart, 0);
            cursor.WriteAt("++++++++++++++++++++++++++++++ Welcome to Epic Build Challenge RPG +++++++++++++++++++++++++++++++++\n", introCenteredBorderStart, 1);
            cursor.WriteAt("--------------------------", introCenteredBorderStart, 2);
            //cursor.WriteAt(" ", 52, 2);
            typeEffect.typeWriterEffect("Prepare for a journey of a lifetime...",52,2);
            cursor.WriteAt("---------------------------------\n", 92, 2);
            cursor.WriteAt("|", introCenteredBorderStart, 3);
            cursor.WriteAt("|", introCenterBorderBounds, 3);
            cursor.WriteAt("+", introCenteredBorderStart, 4);
            cursor.WriteAt("+", introCenterBorderBounds, 4);
            cursor.WriteAt("____________________________________________________________________________________________________\n", introCenteredBorderStart, 5);
            cursor.WriteAt("-------------------------------------------------------------------\n", introPromptSizeFromStart, 6);
            for (int i = 7; i < 25; i++)
            {
                cursor.WriteAt("|", introCenterBorderBounds, i);
                cursor.WriteAt("|", introCenteredBorderStart, i);
                

            }
            for (int i = 7; i < 20; i++)
            {
                cursor.WriteAt("|", introPromptSizeFromStart, i);
                cursor.WriteAt("|", introPromptSizeBounds, i);

            }
            for (int i = introPromptSizeFromStart; i <= introPromptSizeBounds; i++)
            {
                cursor.WriteAt("-", i, 20);


            }
            for (int i = introCenteredBorderStart; i <= introCenterBorderBounds; i++)
            {
                cursor.WriteAt("-", i, 25);


            }

            typeEffect.typeWriterEffect("A long time ago, there existed a race of beings.\n", ((introPromptSizeFromStart+10)),8);
            typeEffect.typeWriterEffectReverse("Prosperity and unending wealth existed.", (introPromptSizeBounds - 12), 9);
            typeEffect.typeWriterEffect("Until one day, a great war broke out.\n", (introPromptSizeFromStart + 17), 10);
            typeEffect.typeWriterEffect("Weeks of war-stricken panic plagued the land.\n", (introPromptSizeFromStart + 12), 12);
            typeEffect.typeWriterEffect("All that remained was a graveyard spread upon ruins.\n", (introPromptSizeFromStart+7), 13);
            typeEffect.typeWriterEffect("A single person rose to the challenge, 'You oh gracious one!'", (introPromptSizeFromStart+5), 14);
            typeEffect.typeWriterEffect("So begins our journey...", (introPromptSizeFromStart + 20), 16);
            cursor.WriteAt("Do you accept this challenge?[Yes/No]",(introPromptSizeFromStart + 7), 23);
            string continuePrompt = Console.ReadLine();
            continuePrompt = continuePrompt.ToUpper();

            if (continuePrompt == "YES")
            {
                Console.Clear();
                return true;

            }
            else
            {
                cursor.WriteAt("You have failed us young warrior.", (introPromptSizeFromStart + 10), 24);
                Console.WriteLine();
                return false;

            }
            
            
          

        }

        public bool tutorialSelect()
        {
            setCursor cursor = new setCursor();

            for (int i = introPromptSizeFromStart; i <= introPromptSizeBounds; i++)
			{
                cursor.WriteAt("-",i,10);
                cursor.WriteAt("-",i,30);
			 
			}

            for (int i = 10; i <= 30; i++)
            {
                cursor.WriteAt("|",introPromptSizeFromStart, i);
                cursor.WriteAt("|",introPromptSizeBounds,i);

            }

            cursor.WriteAt("Would you like to see the tutorial?[Yes/No]", (introPromptSizeFromStart + 15), 15);
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            if(choice == "YES")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public void drawTutBox(int column1, int column2)
        {
            setCursor cursor = new setCursor();

            for (int i = introPromptSizeFromStart; i <= introPromptSizeBounds; i++)
            {
                cursor.WriteAt("-", i, column1);
                cursor.WriteAt("-", i, column2);

            }
            for (int i = column1; i <= column2; i++)
            {
                cursor.WriteAt("|", introPromptSizeFromStart, i);
                cursor.WriteAt("|", introPromptSizeBounds, i);

            }

        }
        public void tutorialDisplay()
        {
            setCursor cursor = new setCursor();
            drawInterface draw = new drawInterface();

            drawTutBox(5,15);
            cursor.WriteAt("This is the resource tracker, to keep track of your buildings.", (introPromptSizeFromStart + 2), 8);
            cursor.WriteAt("[Press Enter to continue]", (introPromptSizeFromStart + 16), 10);
            Console.ReadKey();
            Console.Clear();
            draw.drawCollumm(0, 0, 0, 0, 0, 0, 0, 0, 0);
            draw.drawResourceMatrix(0, 0, 0);
            drawTutBox(25,35);
            cursor.WriteAt("Here we have our resource monitor", (introPromptSizeFromStart + 15), 28);
            cursor.WriteAt("this HUD helps you manage your spending", (introPromptSizeFromStart + 15), 29);
            cursor.WriteAt("[Press Enter to continue]", (introPromptSizeFromStart + 20), 30);
           
            
            




        }
    }
}

