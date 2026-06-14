using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarsGardenSim2026.Components
{
    public partial class WarehouseProgressBar : System.Windows.Forms.ProgressBar
    {
        public WarehouseProgressBar()
        {
            InitializeComponent();
            SimulatorState.Instance.SimulationTick += OnSimulationTick;
        }

        public WarehouseProgressBar(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SimulatorState.Instance.SimulationTick += OnSimulationTick;
        }

        public void Simulate()
        {
            // this is my first time using TryGetValue, I will try to use it in future more often. It doesn't through an exception if the key is not found.
            if (SimulatorState.Instance.CropsOutput.TryGetValue(base.Name, out double output))
            {
                // updates the value of the progress bar with the outputed crops from the CropsScreen via data stored in the SimulatorState singleton
                base.Value = Math.Min((int)SimulatorState.Instance.CropsOutput[base.Name], 10000 - base.Value);
            }
        }

        private void OnSimulationTick(object? sender, EventArgs e)
        {
            Simulate();
        }
    }
}
