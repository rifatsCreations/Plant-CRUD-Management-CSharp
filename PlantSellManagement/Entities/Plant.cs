using PlantSellManagement.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSellManagement.Entities
{
    public class Plant
    {
        int id;
        string name;
        MyPlantType type;
        MyPlantsOrigin origin;
        double price;
        double transportationCost;
        double otherCost;
        double netCost;
        double extraCost;
        string flowerBearing;
        string soil;
        string fertilizer;
       

        public Plant()
        {
            
        }

        public Plant(int id, string name, MyPlantType type, MyPlantsOrigin origin, double price,string flowerBearing, string soil, string fertilizer)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.origin = origin;
            this.price = price;
            
            this.flowerBearing = flowerBearing;
            this.soil = soil;
            this.fertilizer = fertilizer;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public MyPlantType Type { get => type; set => type = value; }
        public MyPlantsOrigin Origin { get => origin; set => origin = value; }
        public double Price { get => price; set => price = value; }
        public double TransportationCost { get => transportationCost; set => transportationCost = value; }
        public double OtherCost { get => otherCost; set => otherCost = value; }
        public double NetCost { get => netCost; set => netCost = value; }
        public double ExtraCost { get => extraCost; set => extraCost = value; }
        public string FlowerBearing { get => flowerBearing; set => flowerBearing = value; }
        public string Soil { get => soil; set => soil = value; }
        public string Fertilizer { get => fertilizer; set => fertilizer = value; }
    }
}