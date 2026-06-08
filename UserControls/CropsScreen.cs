using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarsGardenSim2026.UserControls
{
    public partial class CropsScreen : UserControl
    {
        public CropsScreen()
        {
            InitializeComponent();
        }

        private void crop1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delayTrackBar_Scroll(object sender, EventArgs e)
        {
            SimulatorState.Instance.Delay = delayTrackBar.Value * 1000;
        }
    }
}
