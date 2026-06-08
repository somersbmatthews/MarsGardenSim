using MarsGardenSim2026.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026
{
    public class SimulatorState
    {
        private static readonly SimulatorState _instance = new();

        public int Oxygen { get; set; }

        public int Water { get; set; }

        public Dictionary<string, double> CropsOutput { get; private set; } = new Dictionary<string, double>();

        public int Delay { get; set; } = 1000;

        public TimeSpan TimeElapsed { get; set; }

        // returns instance of its instantiated self in the constructor, key element of a singleton
        public static SimulatorState Instance
        {
            get { return _instance; }
        }


        private SimulatorState()
        {
            CropsInfoMap cropsInfoMap = new CropsInfoMap();

            Dictionary<string, CropProperties> newCrops = cropsInfoMap.Crops;

            foreach (string crop in cropsInfoMap.Crops.Keys)
            {
                CropsOutput.Add(crop, 0);
            }
        }


    }
}
