using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PlantSellManagement.Entities;
using PlantSellManagement.MyEnums;
using PlantSellManagement.Factory;
using PlantSellManagement.Repositoties;


namespace PlantSellManagement
{
    internal class Program
    {
        public static PlantRepository repo=new PlantRepository();
        static void Main(string[] args)
        {

            try
            {
                DoTask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            int operation = 0;
           
            Console.WriteLine("\t\t\t\t\tProject: Plant Management\r");
            Console.WriteLine("\t\t\t\t\t-------------------------\n");
            Console.WriteLine("\t\t\t\t\tName:Md.Rifat Hossain\r");
            Console.WriteLine("\t\t\t\t\tModule:'C Sharp'\r");
                           
            Console.WriteLine("\t\t\t\t\t---------------------------\n");
            Console.WriteLine("How many operation do you want to perform ?");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine("\t\t\t\t\t\t----Select Operation----\nHints: 1-Read,2-Create,3-Update,4-Delete,5-Single");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ShowPlant(null);
                        break;
                    case 2:
                        CreatePlant();
                        break;
                    case 3:
                        UpdatePlant();
                        break;
                    case 4:
                        DeletePlant();
                        break;
                    case 5:
                        ShowSinglePlant();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ShowSinglePlant()
        {
            Console.WriteLine("Enter Plant ID");
            int pltId = Convert.ToInt32(Console.ReadLine());
            Plant plt = repo.GetPlant(pltId);
            ShowPlant(plt);
            
        }

        private static void DeletePlant()
        {
            Console.WriteLine("Enter Plant ID");
            int pltId=Convert.ToInt32(Console.ReadLine());
            Plant detPlt=repo.DeletePlant(pltId);
            ShowPlant(detPlt);
        }

        private static void UpdatePlant()
        {
            Console.WriteLine("Enter Plant ID That You Want To Update");
            int pltId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Plant Name");
            string name = Console.ReadLine();

        EnterPlantType:
            Console.WriteLine("\nEnter Plant Type:\n\nHint:\n1.Indoor \n2.Outdoor ");


            int pTypeValue = Convert.ToInt16(Console.ReadLine());
            MyPlantType plantType;
            try
            {
                plantType = (MyPlantType)(Enum.Parse(typeof(MyPlantType), pTypeValue.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

                goto EnterPlantType;
            }

        PlantsOrigin:
            Console.WriteLine("\nEnter Plant Origin:\n\nHint:\n1.Native \n2.Imported ");

            int pOriginValue = Convert.ToInt16(Console.ReadLine());
            MyPlantsOrigin origin;
            try
            {
                origin = (MyPlantsOrigin)(Enum.Parse(typeof(MyPlantsOrigin), pOriginValue.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

                goto PlantsOrigin;
            }
            Console.WriteLine();

            Console.WriteLine("Enter Plant Price");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter Flower Bearing:\n\nHint:\n1.Yes \n2.No");
            string flowerBearing = Console.ReadLine();
            if (flowerBearing == "1")
            {
                flowerBearing = "Yes";
            }
            else if (flowerBearing == "2")
            {
                flowerBearing = "No";
            }
            else
            {
                Console.WriteLine("Invalid");
            }



            Console.WriteLine("\nEnter Soil Type:\n\nHint:\n1.Cocopit \n2.Coco Fibre \n3.Sandy \n4.Loamy");
            string soil = Console.ReadLine();
            if (soil == "1")
            {
                soil = "Cocopit";
            }
            else if (soil == "2")
            {
                soil = "Coco Fibre";
            }
            else if (soil == "3")
            {
                soil = "Sandy";
            }
            else if (soil == "4")
            {
                soil = "Loamy";
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine("\nEnter Fertilizer Type:\n\nHint:\n1.Vermi Compost \n2.Osmocot \n3.Perlight");
            string fertilizer = Console.ReadLine();
            if (fertilizer == "1")
            {
                fertilizer = "Vermi Compost";
            }
            else if (fertilizer == "2")
            {
                fertilizer = "Osmocot";
            }
            else if (fertilizer == "3")
            {
                fertilizer = "Perlight";
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Plant plant = new Plant(pltId, name, plantType,origin, price,flowerBearing, soil, fertilizer);
            BasePlantFactory pltFactory = new PlantManagerFactory().CreateFactory(plant);
            pltFactory.ApplyCharge();
            Plant upPlt = repo.UpdateNewPlant(plant);
            ShowPlant(upPlt);
        }



        private static void CreatePlant()
        {
            int Id = 0;
            Console.WriteLine("Enter Plant Name");
            string name = Console.ReadLine();

        EnterPlantType:
            Console.WriteLine("\nEnter Plant Type:\n\nHint:\n1.Indoor \n2.Outdoor");

         
            int pTypeValue = Convert.ToInt16(Console.ReadLine());
            MyPlantType plantType;
            try
            {
                plantType = (MyPlantType)(Enum.Parse(typeof(MyPlantType), pTypeValue.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
               
                goto EnterPlantType;
            }

        PlantsOrigin:
            Console.WriteLine("\nEnter Plant Origin:\n\nHint:\n1.Native \n2.Imported ");
           
            int pOriginValue = Convert.ToInt16(Console.ReadLine());
            MyPlantsOrigin origin;
            try
            {
                origin = (MyPlantsOrigin)(Enum.Parse(typeof(MyPlantsOrigin), pOriginValue.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
               
                goto PlantsOrigin;
            }
            Console.WriteLine();
            Console.WriteLine("Enter Plant Price");
            double price = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\nEnter Flower Bearing:\n\nHint:\n1.Yes \n2.No");
            string flowerBearing = Console.ReadLine();
            if (flowerBearing == "1")
            {
                flowerBearing = "Yes";
            }
            else if (flowerBearing == "2")
            {
                flowerBearing = "No";
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            Console.WriteLine("\nEnter Soil Type:\n\nHint:\n1.Cocopit \n2.Coco Fibre \n3.Sandy \n4.Loamy");
            string soil= Console.ReadLine();
            if (soil == "1")
            {
                soil = "Cocopit";
            }
            else if (soil == "2")
            {
                soil = "Coco Fibre";
            }
            else if (soil == "3")
            {
                soil = "Sandy";
            }
            else if (soil == "4")
            {
                soil = "Loamy";
            }
            else 
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine("\nEnter Fertilizer Type:\n\nHint:\n1.Vermi Compost \n2.Osmocot \n3.Perlight");
            string fertilizer = Console.ReadLine();
            if (fertilizer == "1")
            {
                fertilizer = "Vermi Compost";
            }
            else if (fertilizer == "2")
            {
                fertilizer = "Osmocot";
            }
            else if (fertilizer == "3")
            {
                fertilizer = "Perlight";
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            Plant plant = new Plant(Id,name,plantType,origin,price, flowerBearing, soil, fertilizer);
            BasePlantFactory pltFactory = new PlantManagerFactory().CreateFactory(plant);
            pltFactory.ApplyCharge();

            Plant newPlant=repo.CreateNewPlant(plant);
            ShowPlant(newPlant);


        }

        private static void ShowPlant(Plant plt)
        {
           List<Plant>plants = new List<Plant>();
            Console.WriteLine();
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine(string.Format("|{0,-3}|{1,-12}|{2,-10}|{3,-13}|{4,-12}|{5,-10}|{6,-13}|{7,-04}|{8,-09}|{9,-09}| ", "ID", "Name", "Plant Type", "Plants Origin", "Flower Bearing", "Soil", "Fertilizer", "Price","Extra Cost", "Net Price"));
            Console.WriteLine("=============================================================================================================");
            if (plt == null) 
            {
                plants=repo.GetPlants().ToList();
                foreach (Plant item in plants) 
                {
                    Console.WriteLine(string.Format("|{0,-3}|{1,-12}|{2,-10}|{3,-13}| {4,-12} |{5,-10}|{6,-13}| {7,-04}|{8,-09} |{9,-09}|", item.Id, item.Name, item.Type, item.Origin, item.FlowerBearing, item.Soil, item.Fertilizer,item.Price,item.ExtraCost,item.NetCost));
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                Console.WriteLine("==============================================================================================================");
            }
            else
            {
                Console.WriteLine(string.Format("|{0,-3}|{1,-12}|{2,-10}|{3,-13}|{4,-12} |{5,-10}|{6,-13}| {7,-04}|{8,-09}|{9,-09}|", plt.Id, plt.Name, plt.Type, plt.Origin, plt.FlowerBearing, plt.Soil, plt.Fertilizer, plt.Price,plt.ExtraCost,plt.NetCost)); 
            }
            Console.WriteLine();
        }
    }
}
