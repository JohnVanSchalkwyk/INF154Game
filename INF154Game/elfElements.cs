using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class elfElements : basicRaceElements
    {
        private double labourPointDepreciation;
        private double hungerLevelHouseDepreciation;

        public elfElements()
            :base()
        {
            labourPointDepreciation = 0.2;
            hungerLevelHouseDepreciation = 0.5;
        }

        public double getLabourPointDepreciation()
        {
            return labourPointDepreciation;
        }

        public double getHungerLevelHouseDepreciation()
        {
            return hungerLevelHouseDepreciation;
        }
    }
}
