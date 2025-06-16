using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Manager
{
    public class ImportedPlantManager : IPlantManager
    {
      
        public double GetOtherCost()
        {
            return 15;
        }

        public double GetTransportationCost()
        {
            return 10;
        }
    }
}
