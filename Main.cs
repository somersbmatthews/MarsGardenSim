using MarsGardenSim2026.Components;
using System.Runtime.CompilerServices;
using MarsGardenSim2026.Utilities;

namespace MarsGardenSim2026
{

    public partial class Main : Form
    {
        private UserControl SelectableMainScreen = new MainScreen();
        private UserControl SelectableCropsScreen = new UserControls.CropsScreen();
        private UserControl SelectableWarehouseAndSpaceDockScreen = new UserControls.WarehouseAndSpaceDockScreen();

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        private void Main_Load(object? sender, EventArgs e)
        {




        }

        private void LoadSelectedUserControl(UserControl selectedUserControl)
        {
            mainPanel.Controls.Clear();

            selectedUserControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(selectedUserControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSelectedUserControl(SelectableMainScreen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSelectedUserControl(SelectableCropsScreen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSelectedUserControl(SelectableWarehouseAndSpaceDockScreen);
        }

        private void rumSimulation_Click(object sender, EventArgs e)
        {
            //Utilities.ControlExtensions

            IEnumerable<Crop> crops = this.GetAllControlsOfType<Crop>();

            foreach (Crop crop in crops)
            {
                crop.Simulate();
            }
        }



    }
}
