using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class humanElements : basicRaceElements
    {
        private double labourPointGenerationIncrease;
        private int populationSizeIncrease;

       public humanElements()
           :base()
        {
            labourPointGenerationIncrease = 0.2;
            populationSizeIncrease = 100;

        }

       public double getLabourPointGenerationIncrease()
       {
           return labourPointGenerationIncrease;
       }

       public double getPopulationSizeIncrease()
       {
           return populationSizeIncrease;
       }
    }
}
