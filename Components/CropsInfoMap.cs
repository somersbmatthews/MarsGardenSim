using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace MarsGardenSim2026.Components
{
    public class CropsInfoMap
    {
        public Dictionary<String, CropProperties> Crops { get; }
        //public static readonly Dictionary<String, CropProperties> Crops =
        //    new()
        //    {
        //        {
        //            "Potato",
        //            new CropProperties("Potato", 75, 85, 62, 60, 4.50, 45, 8)   
        //        },
        //        {
        //            "Sweet Potatoes",
        //            new CropProperties("Sweet Potatoes", 70, 80, 58, 55, 3.80, 50, 10)
        //        },
        //        {
        //            "Lettuce",
        //            new CropProperties("Lettuce", 95, 32, 23, 30, 2.60, 30, 5)
        //        }
        //    };

        public CropsInfoMap() {

            byte[] bytes = Properties.Resources.Mars_Crops;

            String csv = Encoding.UTF8.GetString(bytes: bytes);

            using StringReader reader = new StringReader(csv);

            string line = null;

            reader.ReadLine(); // skip header

            while ((line = reader.ReadLine()) != null) {

                string[] columns = line.Split(',');

                string name = columns[0];
                int GrowthRate = int.Parse(columns[1]);
                int CO2Usage = int.Parse(columns[2]);
                int O2Produced = int.Parse(columns[3]);
                int WaterUsage = int.Parse(columns[4]);
                int Output = int.Parse(columns[5]);
                int MarketValue = int.Parse(columns[6]);
                int HappinessModifier = int.Parse(columns[7]);

                Crops.Add(name, new CropProperties(name, GrowthRate, CO2Usage, O2Produced, WaterUsage, Output, MarketValue, HappinessModifier));
            }
        }
    }
}
