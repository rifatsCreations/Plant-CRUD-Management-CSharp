using PlantSellManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Contract
{
     public interface IPlantContract
    {
        IEnumerable<Plant> GetPlants();

        Plant GetPlant(int id);
        Plant CreateNewPlant(Plant plant);
        Plant UpdateNewPlant(Plant plant);
        Plant DeletePlant(int id);

    }
}
