namespace MarsGardenSim2026.Components
{
    partial class Crop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            SimulatorState.Instance.SimulationTick -= OnSimulationTick;
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Select_Crop = new ComboBox();
            SuspendLayout();
            // 
            // Select_Crop
            // 
            Select_Crop.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Select_Crop.FormattingEnabled = true;
            Select_Crop.Name = "Select_Crop";
            Select_Crop.Size = new Size(300, 23);
            Select_Crop.TabIndex = 0;
            Select_Crop.SelectedIndexChanged += Select_Crop_SelectedIndexChanged;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Select_Crop;
    }
}
