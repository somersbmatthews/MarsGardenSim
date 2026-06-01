using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace MarsGardenSim2026.Components
{
    public class CropProperties
    {
        public String name {  get; set; }
        public int growthRate {  get; set; }

        public int CO2Usage {  get; set; }

        public int O2Produced { get; set; }

        public int WaterUsage { get; set; }

        public double Output {  get; set; }

        public int MarketValue { get; set; }

        public int HappinessModifier { get; set; }

    }
}
