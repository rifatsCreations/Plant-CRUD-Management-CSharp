using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSellManagement.Entities;
using PlantSellManagement.MyEnums;

namespace PlantSellManagement.Factory
{
     public class PlantManagerFactory
    {
        public BasePlantFactory CreateFactory(Plant plt)
        {
            BasePlantFactory returnValue=null;
            if (plt.Origin == MyPlantsOrigin.Native)
            {
                returnValue= new NativePlantFactory(plt);
            }
            else if (plt.Origin == MyPlantsOrigin.Imported)
            {
                returnValue= new ImportedPlantFactory(plt);
            }
            return returnValue;
        }
    }
}
