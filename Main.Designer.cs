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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            mainPanel = new Panel();
            rumSimulation = new Button();
            lblTimeElapsed = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 4);
            button1.Name = "button1";
            button1.Size = new Size(380, 47);
            button1.TabIndex = 0;
            button1.Text = "Main Screen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(396, 4);
            button2.Name = "button2";
            button2.Size = new Size(386, 47);
            button2.TabIndex = 1;
            button2.Text = "Crops Screen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(788, 4);
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
            // rumSimulation
            // 
            rumSimulation.Location = new Point(1287, 21);
            rumSimulation.Name = "rumSimulation";
            rumSimulation.Size = new Size(167, 23);
            rumSimulation.TabIndex = 4;
            rumSimulation.Text = "Run Simulation";
            rumSimulation.UseVisualStyleBackColor = true;
            rumSimulation.Click += rumSimulation_Click;
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 985);
            Controls.Add(lblTimeElapsed);
            Controls.Add(rumSimulation);
            Controls.Add(mainPanel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel mainPanel;
        private Button rumSimulation;
        private Label lblTimeElapsed;
    }
}
