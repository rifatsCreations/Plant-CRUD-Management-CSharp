using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Manager
{
    public class NativePlantManager : IPlantManager
    {

        public double GetOtherCost()
        {
            return 0;
        }

        public double GetTransportationCost()
        {
            return 3;
        }
    }
}
