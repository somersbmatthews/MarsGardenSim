
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace MarsGardenSim2026.Components
{

    public enum GrowthState
    {
        New,
        Growing,
        Grown
    }

    public partial class Crop : Panel
    {
        private String Name;

        private int GrowthRate;

        private int CO2Usage;

        private int O2Produced;

        private int WaterUsage;

        private double Output;

        private int MarketValue;

        private int HappinessModifier;

        private int cropGrowth;

        Dictionary<String, CropProperties> crops;

        GrowthState growthState;

        public Crop()
        {
            InitializeComponent();
            SetupCrop();
        }

        public Crop(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SetupCrop();
        }

        private void SetupCrop()
        {

            this.BackgroundImage = Properties.Resources.BrownField;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            CropsInfoMap cropsInfoMap = new CropsInfoMap();
            this.crops = cropsInfoMap.Crops;
            string[] crops = cropsInfoMap.Crops.Keys.ToArray();

            Select_Crop.Items.AddRange(crops);

            Select_Crop.Width = 500;
            Select_Crop.Height = 150;
            Select_Crop.Font = new Font("Segoe UI", 14);

            Select_Crop.BringToFront();

            if (!this.Controls.Contains(Select_Crop))
            {
                this.Controls.Add(Select_Crop);
            }
            // this styling occludes the arrow going down
            //Select_Crop.Anchor = AnchorStyles.Top | AnchorStyles.Right; 
        }

        public async void Simulate(int delay)
        {
            while (true)
            {
                if(Select_Crop.SelectedItem == null)
                {
                    await Task.Delay(SimulatorState.Instance.Delay);
                    break;
                }
                //SimulatorState.Instance.CropsOutput[Select_Crop.SelectedItem.ToString()] += GrowthRate;
                //SimulatorState.Instance.CropsOutput[Select_Crop.SelectedItem.ToString()];
                SimulatorState.Instance.Oxygen += O2Produced;
                SimulatorState.Instance.Water -= WaterUsage;
                CheckGrowthStage();
                await Task.Delay(SimulatorState.Instance.Delay);
            }
        }

        private void CheckGrowthStage()
        {
            cropGrowth += GrowthRate;

            String selectedCrop = Select_Crop.SelectedItem.ToString();

            if (selectedCrop == null || !this.crops.Keys.Contains(selectedCrop))
            {
                return;
            }

            string selectedCropSpacesRemoved = selectedCrop.Replace(" ", "");

            if (cropGrowth <= 333)
            {
                growthState = GrowthState.New;
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if(cropGrowth <= 666)
            {
                growthState = GrowthState.Growing;
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_Growing") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                growthState = GrowthState.Grown;
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_Grown") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                if(cropGrowth > 1000)
                {
                    SimulatorState.Instance.CropsOutput[Select_Crop.SelectedItem.ToString()] += 1000;
                    cropGrowth = 0;
                    growthState = GrowthState.New;
                    this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
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
