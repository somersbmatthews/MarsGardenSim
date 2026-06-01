using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026
{
    public class SimulatorState
    {
        private static readonly SimulatorState _instance = new();

        public static SimulatorState Instance => _instance;

        public int Oxygen { get; set; }

        public int Water { get; set; }

        Dictionary<string, double> cropsOutput = new Dictionary<string, double>();
    }
}
