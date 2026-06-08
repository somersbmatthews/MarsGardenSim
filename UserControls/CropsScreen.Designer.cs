namespace MarsGardenSim2026.UserControls
{
    partial class CropsScreen
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropsScreen));
            label1 = new Label();
            crop1 = new MarsGardenSim2026.Components.Crop(components);
            delayTrackBar = new TrackBar();
            crop2 = new MarsGardenSim2026.Components.Crop(components);
            crop3 = new MarsGardenSim2026.Components.Crop(components);
            crop4 = new MarsGardenSim2026.Components.Crop(components);
            ((System.ComponentModel.ISupportInitialize)delayTrackBar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1286, 48);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Crops Screen";
            // 
            // crop1
            // 
            crop1.BackgroundImage = (Image)resources.GetObject("crop1.BackgroundImage");
            crop1.BackgroundImageLayout = ImageLayout.Stretch;
            crop1.Location = new Point(27, 81);
            crop1.Name = "crop1";
            crop1.Size = new Size(503, 287);
            crop1.TabIndex = 1;
            crop1.Paint += crop1_Paint;
            // 
            // delayTrackBar
            // 
            delayTrackBar.Location = new Point(214, 18);
            delayTrackBar.Minimum = 1;
            delayTrackBar.Name = "delayTrackBar";
            delayTrackBar.Size = new Size(778, 45);
            delayTrackBar.TabIndex = 2;
            delayTrackBar.Value = 1;
            delayTrackBar.Scroll += delayTrackBar_Scroll;
            // 
            // crop2
            // 
            crop2.BackgroundImage = (Image)resources.GetObject("crop2.BackgroundImage");
            crop2.BackgroundImageLayout = ImageLayout.Stretch;
            crop2.Location = new Point(592, 85);
            crop2.Name = "crop2";
            crop2.Size = new Size(507, 283);
            crop2.TabIndex = 3;
            // 
            // crop3
            // 
            crop3.BackgroundImage = (Image)resources.GetObject("crop3.BackgroundImage");
            crop3.BackgroundImageLayout = ImageLayout.Stretch;
            crop3.Location = new Point(26, 382);
            crop3.Name = "crop3";
            crop3.Size = new Size(504, 308);
            crop3.TabIndex = 4;
            // 
            // crop4
            // 
            crop4.BackgroundImage = (Image)resources.GetObject("crop4.BackgroundImage");
            crop4.BackgroundImageLayout = ImageLayout.Stretch;
            crop4.Location = new Point(591, 385);
            crop4.Name = "crop4";
            crop4.Size = new Size(508, 305);
            crop4.TabIndex = 5;
            // 
            // CropsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Mars_Surface;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(crop4);
            Controls.Add(crop3);
            Controls.Add(crop2);
            Controls.Add(delayTrackBar);
            Controls.Add(crop1);
            Controls.Add(label1);
            Name = "CropsScreen";
            Size = new Size(1622, 801);
            ((System.ComponentModel.ISupportInitialize)delayTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Components.Crop crop1;
        private TrackBar delayTrackBar;
        private Components.Crop crop2;
        private Components.Crop crop3;
        private Components.Crop crop4;
    }
}
