using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace MarsGardenSim2026.Components
{
    public class CropProperties
    {

        public String Name {  get; set; }
        public int GrowthRate {  get; set; }

        public int CO2Usage {  get; set; }

        public int O2Produced { get; set; }

        public int WaterUsage { get; set; }

        public double Output {  get; set; }

        public double MarketValue { get; set; }

        public int HappinessModifier { get; set; }

        public CropProperties(String name, int growthRate, int c02Usage, int o2Produced, int waterUsage, double output, double marketValue, int happinessModifier)
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
