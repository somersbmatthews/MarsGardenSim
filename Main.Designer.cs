namespace MarsGardenSim2026
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button3 = new Button();
            mainPanel = new Panel();
            lblTimeElapsed = new Label();
            simulationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(27, 4);
            button2.Name = "button2";
            button2.Size = new Size(386, 47);
            button2.TabIndex = 1;
            button2.Text = "Crops Screen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(419, 4);
            button3.Name = "button3";
            button3.Size = new Size(377, 47);
            button3.TabIndex = 2;
            button3.Text = "Warehouse Screen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(12, 57);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1882, 931);
            mainPanel.TabIndex = 3;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(1764, 23);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(77, 15);
            lblTimeElapsed.TabIndex = 5;
            lblTimeElapsed.Text = "Time Elapsed";
            lblTimeElapsed.Click += lblTimeElapsed_Click;
            // 
            // simulationTimer
            // 
            simulationTimer.Interval = 1000;
            simulationTimer.Tick += simulationTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 985);
            Controls.Add(lblTimeElapsed);
            Controls.Add(mainPanel);
            Controls.Add(button3);
            Controls.Add(button2);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Panel mainPanel;
        private Label lblTimeElapsed;
        private System.Windows.Forms.Timer simulationTimer;
    }
}
