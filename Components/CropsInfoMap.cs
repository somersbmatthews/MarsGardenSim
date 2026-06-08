using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace MarsGardenSim2026.Components
{
    public class CropsInfoMap
    {
        // dictionary to hold the crops and their properties
        public Dictionary<String, CropProperties> Crops { get; } = new Dictionary<string, CropProperties>();

        public CropsInfoMap() {

            // this is a byte array of the csv
            byte[] bytes = Properties.Resources.Mars_Crops;
            // csv file of the UTF-8 file
            String csv = Encoding.UTF8.GetString(bytes: bytes);
            // read the csv
            using StringReader reader = new StringReader(csv);
            // empty line set to null
            string line = null;

            reader.ReadLine(); // skip header
            // read each line of the csv and create CropProperties objects, then add each to the Crops dictionary
            while ((line = reader.ReadLine()) != null) {

                string[] columns = line.Split(',');

                string name = columns[0];
                int GrowthRate = int.Parse(columns[1]);
                int CO2Usage = int.Parse(columns[2]);
                int O2Produced = int.Parse(columns[3]);
                int WaterUsage = int.Parse(columns[4]);
                double Output = double.Parse(columns[5]);
                int MarketValue = int.Parse(columns[6]);
                int HappinessModifier = int.Parse(columns[7]);

                Crops.Add(name, new CropProperties(name, GrowthRate, CO2Usage, O2Produced, WaterUsage, Output, MarketValue, HappinessModifier));
            }
            reader.Close();
        }
    }
}
