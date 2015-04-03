using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF154Game
{
    public class cyborgELements:basicRaceElements
    {
        private double labourPointSubstitutionDecrease;
        private double resourceDepreciationRate;

        public cyborgELements()
            :base()
        {
            labourPointSubstitutionDecrease = 0.5;
            resourceDepreciationRate = 0.2;
        }

        public double getLabourPointSubstitutionDecrease()
        {
            return labourPointSubstitutionDecrease;
        }

        public double getResourceDepreciationRate()
        {
            return resourceDepreciationRate;
        }
    }
}
