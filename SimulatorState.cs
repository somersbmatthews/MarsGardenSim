using MarsGardenSim2026.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace MarsGardenSim2026
{
    public class SimulatorState
    {
        // This instantiates an "Event Bus" EventHandler object that components can subscribe to.
        public event EventHandler? SimulationTick;
        // This method raises invokes the events in the event bus with initial event args object if and only if the SimulationTick object is not null
        internal void RaiseTick()
        {
            SimulationTick?.Invoke(this, EventArgs.Empty);
        }
        // SimulatorState instantiated instance.
        private static readonly SimulatorState _instance = new();

        // Oxygen available. Currently not a feature
        public int Oxygen { get; set; } = 10000;

        // Water available. Currently not a feature
        public int Water { get; set; } = 100000;

        // a dictionary of the crops and their output
        public ConcurrentDictionary<string, double> CropsOutput { get; private set; } = new ConcurrentDictionary<string, double>();

        // the delay between each iteration of the simulation.
        public int Delay { get; set; } = 1000;

        // This is the time span that is displayed at the top right of the UI
        public TimeSpan TimeElapsed { get; set; }

        // returns instance of its instantiated self in the constructor
        public static SimulatorState Instance
        {
            get { return _instance; }
        }

        // This private constructor is called on the instantiation of the SimulatorState class
        private SimulatorState()
        {
            // initialize the cropsInfoMap class
            CropsInfoMap cropsInfoMap = new CropsInfoMap();

            // iterates through cropsInfoMap.Crops.Keys and adds them to the CropsOutput dictionary
            foreach (string crop in cropsInfoMap.Crops.Keys)
            {
                CropsOutput.TryAdd(crop, 0);
            }
        }


    }
}

// Documentation on the EventHandler as a delegate.
// https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-10.0
