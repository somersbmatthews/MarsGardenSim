
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Timers;

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
        // not yet a feature, but planned
        private int CO2Usage;
        // not yet a feature, but planned
        private int O2Produced;
        // not yet a feature, but planned
        private int WaterUsage;
        // not yet a feature, but planned
        private double Output;
        // not yet a feature, but planned
        private int MarketValue;
        // not yet a feature, but planned
        private int HappinessModifier;
        // total crop growth
        private int cropGrowth;
        // a dictionary to hold the crops and their respective relative properties
        Dictionary<String, CropProperties> crops;

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

        private void Crop_Load(object sender, EventArgs e)
        {
            this.Select_Crop.SelectedIndex = 0;
        }

        private void SetupCrop()
        {
            // Subscribe OnSimulationTick delegate to EventHandler "Event Bus"
            SimulatorState.Instance.SimulationTick += OnSimulationTick;
            // background image is set to the brown field
            this.BackgroundImage = Properties.Resources.BrownField;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // crops info map
            CropsInfoMap cropsInfoMap = new CropsInfoMap();
            this.crops = cropsInfoMap.Crops;
            string[] crops = cropsInfoMap.Crops.Keys.ToArray();
            // adds full range of crops to the cropsInfoMap
            Select_Crop.Items.AddRange(crops);
            // sets the width and height of the crops comboBox drop down
            Select_Crop.Width = 500;
            Select_Crop.Height = 150;
            // sets the font size and type
            Select_Crop.Font = new Font("Segoe UI", 14);
            // brings the comboBox to the front, probably not needed.
            Select_Crop.BringToFront();
            // this is unfortunate but adding the combobox to the crops designer did not work
            if (!this.Controls.Contains(Select_Crop))
            {
                this.Controls.Add(Select_Crop);
            }
            // this styling occludes the arrow going down
            //Select_Crop.Anchor = AnchorStyles.Top | AnchorStyles.Right; 
        }

        public void Simulate()
        {      
            // if no crop is selected, nothing happens
            if(Select_Crop.SelectedItem == null)
            {
               return;
            }
            // tracks resources used from singleton
            SimulatorState.Instance.Oxygen += O2Produced;
            SimulatorState.Instance.Water -= WaterUsage;
            // checks the growth stage
            CheckGrowthStage();
            // waits so the infinite loop doesn't use too much cpu
        }

        private void CheckGrowthStage()
        {
            // increments the crop's growth by the crop's relative growth rate integer
            cropGrowth += GrowthRate;

            // selected crop from the comboBox
            String selectedCrop = Select_Crop.SelectedItem.ToString();

            if (selectedCrop == null || !this.crops.Keys.Contains(selectedCrop))
            {
                return;
            }
            // if a crop has two words, it removes the space between them before accessing the image
            string selectedCropSpacesRemoved = selectedCrop.Replace(" ", "");

            if (cropGrowth <= 333) // new growth state
            {

                // sets the image
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if(cropGrowth <= 666) // growing growth state
            {
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_Growing") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else // grown growth state
            {
                this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_Grown") as Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                if(cropGrowth > 1000) // grown growth state and the crop is harvested.
                {
                    SimulatorState.Instance.CropsOutput[Select_Crop.SelectedItem.ToString()] += 1000;
                    cropGrowth = 0;
                    this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            
        }

        private void Select_Crop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selected crop from the comboBox
            String selectedCrop = Select_Crop.SelectedItem.ToString();

            // if no crop is selected, nothing happens, or if there is bug and no crop is in the data, the image disappears but the app does not crash
            if (selectedCrop == null || !this.crops.Keys.Contains(selectedCrop))
            {
                return;
            }

            // sets the crops properties
            CropProperties selectedCropProperties = this.crops[selectedCrop];
            Name = selectedCropProperties.Name;
            GrowthRate = selectedCropProperties.GrowthRate;
            CO2Usage = selectedCropProperties.CO2Usage;
            O2Produced = selectedCropProperties.O2Produced;
            WaterUsage = selectedCropProperties.WaterUsage;
            Output = selectedCropProperties.Output;
            MarketValue = selectedCropProperties.MarketValue;
            HappinessModifier = selectedCropProperties.HappinessModifier;

            // if a crop has two words, it removes the space between them before accessing the image
            string selectedCropSpacesRemoved = selectedCrop.Replace(" ", "");
            // sets the accessed image
            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{selectedCropSpacesRemoved}_New") as Image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // This is the event that is subscribed to the event bus that calls Simulate() on timer interval tick of one second.
        private void OnSimulationTick(object? sender, EventArgs e)
        {
            Simulate();
        }
    }
}
