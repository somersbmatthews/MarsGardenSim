using MarsGardenSim2026.Components;
using MarsGardenSim2026.UserControls;
using MarsGardenSim2026.Utilities;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MarsGardenSim2026
{

    public partial class Main : Form
    {
        private UserControl SelectableMainScreen;
        private UserControl SelectableCropsScreen;
        private UserControl SelectableWarehouseAndSpaceDockScreen;
        

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        private void Main_Load(object? sender, EventArgs e)
        {
            lblTimeElapsed.Text = SimulatorState.Instance.TimeElapsed.ToString(@"hh\:mm\:ss");

            SelectableCropsScreen = new CropsScreen();
            SelectableWarehouseAndSpaceDockScreen = new WarehouseAndSpaceDockScreen();

            LoadScreen(SelectableCropsScreen);
            LoadScreen(SelectableWarehouseAndSpaceDockScreen);
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
            IEnumerable<Crop> crops = this.GetAllControlsOfType<Crop>();

            foreach (Crop crop in crops)
            {
                crop.Simulate(SimulatorState.Instance.Delay);
            }
            runTimeElapsed();

        }

        private async void runTimeElapsed()
        {
            while (true)
            {
                TimeSpan timeSpan = TimeSpan.FromMilliseconds(SimulatorState.Instance.TimeElapsed.TotalMilliseconds + SimulatorState.Instance.Delay);

                SimulatorState.Instance.TimeElapsed = timeSpan;

                lblTimeElapsed.Text = SimulatorState.Instance.TimeElapsed.ToString(@"hh\:mm\:ss");

                await Task.Delay(SimulatorState.Instance.Delay);
            }
        }

        private void lblTimeElapsed_Click(object sender, EventArgs e)
        {

        }
    }
}
