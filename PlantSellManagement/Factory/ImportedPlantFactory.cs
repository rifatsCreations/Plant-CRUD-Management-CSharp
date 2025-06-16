using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSellManagement.Entities;
using PlantSellManagement.Manager;

namespace PlantSellManagement.Factory
{
    public class ImportedPlantFactory : BasePlantFactory
    {
        public ImportedPlantFactory(Plant plt) : base(plt)
        {

        }

        public override IPlantManager Create()
        {
            ImportedPlantManager manager = new ImportedPlantManager();
            double net= _plt.TransportationCost + _plt.OtherCost + _plt.Price;
            double extraCost = _plt.NetCost - _plt.Price;
            return manager;
        }
    }
}
