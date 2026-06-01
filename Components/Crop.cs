
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MarsGardenSim2026.Components
{
    public enum CropType {

    }
    public partial class Crop : Panel
    {
        double growth = 0.0;
        double growthIncrementer = 0.0;
        

        public Crop()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.BrownField;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //CropsInfoMap cropsInfoMap = new CropsInfoMap();
            //cropsInfoMap.CropsDictionary.add("Potato", null);
            


        }

        public Crop(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Simulate()
        {
            
        }

        private void addCropProperties()
        {
            CropProperties cropsProperties = CropsInfoMap.Crops["Potato"];
        }

    }
}
