using PlantSellManagement.Contract;
using PlantSellManagement.Entities;
using PlantSellManagement.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Repositoties
{
    public class PlantRepository : IPlantContract
    {
        private readonly List<Plant> plantList;

        public PlantRepository()
        {
            plantList = new List<Plant>()
            {

               new Plant(){Id=1,Name="AgloeNema",Type=MyPlantType.Indoor,Origin=MyPlantsOrigin.Imported,Price=600,FlowerBearing="No",Soil="Cocopit",Fertilizer="Vermi Compost"},

               new Plant(){Id=2,Name="Dendrobium",Type=MyPlantType.Indoor,Origin=MyPlantsOrigin.Imported,Price=900,FlowerBearing="Yes",Soil="Coco Fibre",Fertilizer="Osmocot"},

               new Plant()
                 {Id=3,Name="Neon Pothos",Type=MyPlantType.OutDoor,Origin=MyPlantsOrigin.Native,Price=200,FlowerBearing="No",Soil="Cocopit",Fertilizer="Vermi Compost"},

               new Plant(){Id=4,Name="Cactus",Type=MyPlantType.OutDoor,Origin=MyPlantsOrigin.Native,Price=250,FlowerBearing="Yes",Soil="Sandy",Fertilizer="Osmocot"},

               new Plant(){Id=5,Name="Succulent",Type=MyPlantType.Indoor,Origin=MyPlantsOrigin.Imported,Price=500,FlowerBearing="No",Soil="Cocopit",Fertilizer="Perlight"},

               new Plant()
                {Id=6,Name="Lucky Bambo",Type=MyPlantType.OutDoor,Origin=MyPlantsOrigin.Native,Price=150,FlowerBearing="No",Soil="Cocopit",Fertilizer="Vermi Compost"},

               new Plant(){Id=7,Name="Oxalis",Type=MyPlantType.OutDoor,Origin=MyPlantsOrigin.Native,Price=250,FlowerBearing="Yes",Soil="Loamy",Fertilizer="Vermi Compost"},

                new Plant(){Id=8,Name="Monstera",Type=MyPlantType.Indoor,Origin=MyPlantsOrigin.Imported,Price=1500,FlowerBearing="No",Soil="Cocopit",Fertilizer="Vermi Compost"}


            };
        }
        public Plant CreateNewPlant(Plant plant)
        {
            Plant existingPlant=(from p in plantList orderby p.Id descending select p).FirstOrDefault();
            plant.Id = existingPlant.Id + 1;
            plantList.Add(plant);
            return plant;
        }

        public Plant DeletePlant(int id)
        {
          var plant = GetPlant(id);
            if (plant != null)
            {
                plantList.Remove(plant);
            }
            return plant;
        }

        public Plant GetPlant(int id)
        {
           var plt=(from row in plantList where row.Id == id select row).FirstOrDefault();
            return plt;
        }

        public IEnumerable<Plant> GetPlants()
        {
            return from rows in plantList select rows;
        }

        public Plant UpdateNewPlant(Plant upPlt)
        {
            Plant plt=GetPlant(upPlt.Id);
            if (plt != null)
            {
                plt.Name = upPlt.Name;
                plt.Type = upPlt.Type;
                plt.Origin = upPlt.Origin;
                plt.Price = upPlt.Price;    
                plt.TransportationCost = upPlt.TransportationCost;
                plt.OtherCost = upPlt.OtherCost;
                plt.NetCost = upPlt.NetCost;
                plt.ExtraCost= upPlt.ExtraCost;
                plt.FlowerBearing = upPlt.FlowerBearing;
                plt.Soil= upPlt.Soil;
                plt.Fertilizer = upPlt.Fertilizer;
            }
            return plt;
        }
    }
}
