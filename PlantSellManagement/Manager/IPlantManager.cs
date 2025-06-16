using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Manager
{
    public interface IPlantManager
    {
        double GetTransportationCost();
        double GetOtherCost();
       
    }
}
