using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class basicRaceElements
    {
        private int labourPointStart;
        private int populationStart;
        private int totalNumberOfHomes;
        
        private double labourPointGenerationRate;
        private double hungerPointGenerationRate;

        public basicRaceElements()
        {
            labourPointStart = 200;
            populationStart = 0;
            totalNumberOfHomes = 0;
            labourPointGenerationRate = 0.05;
            hungerPointGenerationRate = 0.05;
        }

        public int getLabourPointStart()
        {
            return labourPointStart;
        }

        public int getPopulationStart()
        {
            return populationStart;
        }

        public double getLabourPointGenerationRate()
        {
            return labourPointGenerationRate;
        }

        public double getHungerPointGenerationRate()
        {
            return hungerPointGenerationRate;
        }


    }
}
