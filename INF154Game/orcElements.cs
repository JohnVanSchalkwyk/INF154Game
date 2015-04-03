using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class orcElements : basicRaceElements
    {
        private double hungerLevelDepreciationRate;
        private double labourPointReductionRate;

        public orcElements()
            : base()
        {
            hungerLevelDepreciationRate = 0.3;
            labourPointReductionRate = 0.15;
        }

        public double getHungerLevelDepreciationRate()
        {
            return hungerLevelDepreciationRate;
        }

        public double getLabourPointReductionRate()
        {
            return labourPointReductionRate;
        }
        
    }
}
 