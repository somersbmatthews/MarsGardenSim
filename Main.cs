using MarsGardenSim2026.Components;
using MarsGardenSim2026.UserControls;
using MarsGardenSim2026.Utilities;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MarsGardenSim2026
{

    public partial class Main : Form
    {
        private UserControl SelectableCropsScreen;
        private UserControl SelectableWarehouseAndSpaceDockScreen;

        public System.Windows.Forms.Timer GetSimulationTimer
        {
            get { return simulationTimer; }
        }

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        private void Main_Load(object? sender, EventArgs e)
        {
            SelectableCropsScreen = new CropsScreen();
            SelectableWarehouseAndSpaceDockScreen = new WarehouseAndSpaceDockScreen();

            LoadScreen(SelectableCropsScreen);
            LoadScreen(SelectableWarehouseAndSpaceDockScreen);
            simulationTimer.Start();
        }

        private void LoadScreen(UserControl screen)
        {
            screen.Dock = DockStyle.Fill;
            screen.Visible = false;
            mainPanel.Controls.Add(screen);

            LoadSelectedUserControl(SelectableCropsScreen);
        }

        private void LoadSelectedUserControl(UserControl selectedScreen)
        {
            foreach (Control control in mainPanel.Controls)
            {
                control.Visible = false;
            }

            selectedScreen.Visible = true;
            selectedScreen.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSelectedUserControl(SelectableCropsScreen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSelectedUserControl(SelectableWarehouseAndSpaceDockScreen);
        }

        private void lblTimeElapsed_Click(object sender, EventArgs e)
        {

        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            SimulatorState.Instance.RaiseTick();
            //IEnumerable<Crop> crops = this.GetAllControlsOfType<Crop>();

            //foreach (Crop crop in crops)
            //{
            //    crop.Simulate();
            //}
        }
    }
}

// Timer documentation
// https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.timer?view=windowsdesktop-10.0