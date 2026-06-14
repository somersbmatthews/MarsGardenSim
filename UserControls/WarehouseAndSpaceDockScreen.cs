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
            this.Load += WarehouseAndSpaceDockScreen_Load;
        }

        private void WarehouseAndSpaceDockScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateCropsComponents()
        {
            // count of total crops availabe to plant
            int cropsCount = SimulatorState.Instance.CropsOutput.Keys.Count;
            // lsit of crops
            List<string> cropsList = SimulatorState.Instance.CropsOutput.Keys.ToList();

            // column count to track what column of progress bars we are at
            int columnCount = 1;

            // width and height of progress bars
            int width = 200;
            int height = 25;

            // loop to iterate through the crops at create a progress bar and label for each
            for (int i = 0; i < cropsCount; i++)
            {
                // instantiates a new progress bar
                WarehouseProgressBar progressBar = new WarehouseProgressBar();

                // divides the crops count by 10;
                if (i % 10 == 0)
                {
                    // column count is number of crops divided by 10 
                    columnCount = i / 10;
                }

                // sets the horizontal location of the progress bar
                int x = columnCount * 250;
                // sets the vertical location of the progress bar
                int y = 10 + i * 30 - (300 * columnCount);

                // sets the location of the progress bar from above x and y
                progressBar.Location = new Point(x, y);

                // sets the min and max values of the progress bar.
                progressBar.Minimum = 0;
                progressBar.Maximum = 10000;
                // sets the value of the progress bar, makes sure it doesn't exceed the progress bar maxiumum capacity (this limitation might not be needed)
                progressBar.Value = Math.Min((int)SimulatorState.Instance.CropsOutput[cropsList[i]], progressBar.Maximum - progressBar.Value);
                // sets the size of the progress bar
                progressBar.Size = new Size(width, height);
                // sets the name of the progress bar, which is a crop from the list of crops from the instantiated singleton dictionary
                progressBar.Name = cropsList[i];


                // instantiates a new label
                Label cropLabel = new Label();
                // sets the text of the label a crop from the progress bar
                cropLabel.Text = cropsList[i];
                cropLabel.AutoSize = true;

                // sets the location of the label using an x and y
                cropLabel.Location = new Point(
                    x + 20,  // 100 pixels to the left
                    y + 4     // vertically align with bar
                );
                // adds the progress bar and corresponding label to the Controls collection
                this.Controls.Add(progressBar);
                this.Controls.Add(cropLabel);

                // brings to the front both the progress bar and label
                progressBar.BringToFront();
                cropLabel.BringToFront();
            }
        }
    }
}
