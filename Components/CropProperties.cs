using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace MarsGardenSim2026.Components
{
    // data class for all the properties, please see Crop.cs for an example of some of their usage and purposes
    public class CropProperties
    {

        public String Name {  get; set; }
        public int GrowthRate {  get; set; }

        public int CO2Usage {  get; set; }

        public int O2Produced { get; set; }

        public int WaterUsage { get; set; }

        public double Output {  get; private set; }

        public int MarketValue { get; set; }

        public int HappinessModifier { get; set; }

        public CropProperties(String name, int growthRate, int c02Usage, int o2Produced, int waterUsage, double output, int marketValue, int happinessModifier)
        {
            Name = name;
            GrowthRate = growthRate;
            CO2Usage = c02Usage;
            O2Produced = o2Produced;
            WaterUsage = waterUsage;
            Output = output;
            MarketValue = marketValue;
            HappinessModifier = happinessModifier;
        }

    }
}
