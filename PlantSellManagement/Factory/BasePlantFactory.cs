using PlantSellManagement.Entities;
using PlantSellManagement.Manager;
using PlantSellManagement.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Factory
{
    public abstract class BasePlantFactory
    {
        public abstract IPlantManager Create();
        protected Plant _plt;

        protected BasePlantFactory(Plant plt)
        {
            _plt = plt;
        }

        public Plant ApplyCharge()
        {
            IPlantManager manager =this. Create();
            _plt.TransportationCost = manager.GetTransportationCost() / 100 * _plt.Price;
            _plt.OtherCost = manager.GetOtherCost() / 100 * _plt.Price;

            if (_plt.Origin == MyPlantsOrigin.Imported)
            {
                _plt.NetCost=_plt.TransportationCost+_plt.OtherCost+_plt.Price;
            }
            else
            {
                _plt.NetCost = _plt.TransportationCost + _plt.Price;
               
            }
            _plt.ExtraCost = _plt.NetCost - _plt.Price;

            return _plt;
        }

    }
}
