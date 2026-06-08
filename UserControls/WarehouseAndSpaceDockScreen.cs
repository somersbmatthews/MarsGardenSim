using MarsGardenSim2026.Components;
using MarsGardenSim2026.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarsGardenSim2026.UserControls
{
    public partial class WarehouseAndSpaceDockScreen : UserControl
    {
        public WarehouseAndSpaceDockScreen()
        {
            InitializeComponent();
            CreateCropsComponents();
            UpdateProgressBars();
        }

        private void CreateCropsComponents()
        {
            int cropsCount = SimulatorState.Instance.CropsOutput.Keys.Count;
            List<string> cropsList = SimulatorState.Instance.CropsOutput.Keys.ToList();

            int columnCount = 1;

            int width = 200;
            int height = 25;

            for (int i = 0; i < cropsCount; i++)
            {
                ProgressBar progressBar = new ProgressBar();
                
                if(i % 10 == 0)
                {
                    columnCount = i / 10;
                }

                int x = columnCount * 250;
                int y = 10 + i * 30 - (300 * columnCount);

                progressBar.Location = new Point(x, y);

                progressBar.Minimum = 0;
                progressBar.Maximum = 1000;
                progressBar.Value = Math.Min((int)SimulatorState.Instance.CropsOutput[cropsList[i]], progressBar.Maximum);
                progressBar.Size = new Size(width, height);
                progressBar.Name = cropsList[i];

                

                Label cropLabel = new Label();
                cropLabel.Text = cropsList[i];
                cropLabel.AutoSize = true;

                cropLabel.Location = new Point(
                    x + 20,  // 100 pixels to the left
                    y + 4     // vertically align with bar
                );

                this.Controls.Add(progressBar);
                this.Controls.Add(cropLabel);

                
                progressBar.BringToFront();
                cropLabel.BringToFront();


            }
        }

        private async void UpdateProgressBars()
        {
            IEnumerable<ProgressBar> progressBars = this.GetAllControlsOfType<ProgressBar>();

            int cropsCount = SimulatorState.Instance.CropsOutput.Keys.Count;
            List<string> cropsList = SimulatorState.Instance.CropsOutput.Keys.ToList();

            int count = 0;

            foreach (ProgressBar progressBar in progressBars)
            {
                count++;
                if(count % 80 == 0)
                {
                    await Task.Delay(700);
                }
                


                if (this.IsHandleCreated)
                {
                    await Task.Run(() =>
                    {
                        Invoke(() =>
                        {
                            if (progressBar.Name == "Potatoes")
                            {
                               int i = 1;
                            
                            // sets the progress bar value equal to the player health
                            progressBar.Value = Math.Min((int)SimulatorState.Instance.CropsOutput[progressBar.Name], 1000);
                            Dictionary<string, double> CropsOutputhere1 = SimulatorState.Instance.CropsOutput;
                            }
                            progressBar.Value = Math.Min((int)SimulatorState.Instance.CropsOutput[progressBar.Name], 1000);
                            Dictionary<string, double> CropsOutputhere2 = SimulatorState.Instance.CropsOutput;
                        });

                    });
                }
            }
        }
    }
}
