using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026
{
    public class SimulatorState
    {
        private static readonly SimulatorState _instance = new();

        // returns instance of its instantiated self in the constructor, key element of a singleton
        public static SimulatorState Instance
        {
            get { return _instance; }
        }

        public int Oxygen { get; set; }

        public int Water { get; set; }

        Dictionary<string, double> cropsOutput { get; set; } = new Dictionary<string, double>();
    }
}
