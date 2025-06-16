using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSellManagement.Entities;
using PlantSellManagement.Manager;

namespace PlantSellManagement.Factory
{
    public class NativePlantFactory : BasePlantFactory
    {
        public NativePlantFactory(Plant plt) : base(plt)
        {
        }

        public override IPlantManager Create()
        {
            NativePlantManager manager = new NativePlantManager();
            double net= _plt.TransportationCost + _plt.Price;
            double extraCost = _plt.NetCost - _plt.Price;
            return manager;
            
        }
    }
}
