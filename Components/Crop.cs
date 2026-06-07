
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MarsGardenSim2026.Components
{
    public partial class Crop : Panel
    {
        public String Name;

        public int GrowthRate;

        public int CO2Usage;

        public int O2Produced;

        public int WaterUsage;

        public double Output;

        public double MarketValue;

        public int HappinessModifier;

        Dictionary<String, CropProperties> crops;

        public Crop()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.BrownField;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            CropsInfoMap cropsInfoMap = new CropsInfoMap();
            this.crops = cropsInfoMap.Crops;
            string[] crops = cropsInfoMap.Crops.Keys.ToArray();

            Select_Crop.Items.AddRange(crops);

            Select_Crop.Width = 30;
            Select_Crop.Height = 30;
        }

        public Crop(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public async void Simulate()
        {
            while (true)
            {
                SimulatorState.Instance.Oxygen += O2Produced;
                SimulatorState.Instance.Water -= WaterUsage;
                await Task.Delay(1000);
            }
        }

        private void Select_Crop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedCrop = Select_Crop.SelectedItem.ToString();

            if (selectedCrop == null || !this.crops.Keys.Contains(selectedCrop))
            {
                return;
            }

            CropProperties selectedCropProperties = this.crops[selectedCrop];
            Name = selectedCropProperties.Name;
            GrowthRate = selectedCropProperties.GrowthRate;
            CO2Usage = selectedCropProperties.CO2Usage;
            O2Produced = selectedCropProperties.O2Produced;
            WaterUsage = selectedCropProperties.WaterUsage;
            Output = selectedCropProperties.Output;
            MarketValue = selectedCropProperties.MarketValue;
            HappinessModifier = selectedCropProperties.HappinessModifier;

            string selectedCropSpacesRemoved = selectedCrop.Replace(" ", "");

            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
