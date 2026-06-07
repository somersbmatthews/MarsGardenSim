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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1456, 103);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Crops Screen";
            // 
            // crop1
            // 
            crop1.BackgroundImage = (Image)resources.GetObject("crop1.BackgroundImage");
            crop1.BackgroundImageLayout = ImageLayout.Stretch;
            crop1.Location = new Point(84, 152);
            crop1.Name = "crop1";
            crop1.Size = new Size(969, 485);
            crop1.TabIndex = 1;
            crop1.Paint += crop1_Paint;
            // 
            // CropsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(crop1);
            Controls.Add(label1);
            Name = "CropsScreen";
            Size = new Size(1622, 801);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Components.Crop crop1;
    }
}
