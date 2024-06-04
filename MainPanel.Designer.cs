namespace FlightReservationApp
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            reservBtn = new Button();
            locBtn = new Button();
            aircrftBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // reservBtn
            // 
            reservBtn.BackColor = SystemColors.Control;
            reservBtn.Image = (Image)resources.GetObject("reservBtn.Image");
            reservBtn.Location = new Point(616, 221);
            reservBtn.Name = "reservBtn";
            reservBtn.Size = new Size(216, 162);
            reservBtn.TabIndex = 3;
            reservBtn.UseVisualStyleBackColor = false;
            reservBtn.Click += reservBtn_Click;
            // 
            // locBtn
            // 
            locBtn.BackColor = SystemColors.Control;
            locBtn.Image = (Image)resources.GetObject("locBtn.Image");
            locBtn.Location = new Point(350, 221);
            locBtn.Name = "locBtn";
            locBtn.Size = new Size(215, 162);
            locBtn.TabIndex = 4;
            locBtn.UseVisualStyleBackColor = false;
            locBtn.Click += button2_Click;
            // 
            // aircrftBtn
            // 
            aircrftBtn.BackColor = SystemColors.Control;
            aircrftBtn.Image = (Image)resources.GetObject("aircrftBtn.Image");
            aircrftBtn.Location = new Point(65, 221);
            aircrftBtn.Name = "aircrftBtn";
            aircrftBtn.Size = new Size(215, 162);
            aircrftBtn.TabIndex = 5;
            aircrftBtn.UseVisualStyleBackColor = false;
            aircrftBtn.Click += aircrftBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(95, 126);
            label1.Name = "label1";
            label1.Size = new Size(716, 41);
            label1.TabIndex = 6;
            label1.Text = "PLEASE SELECT THE ACTION YOU WANT TO TAKE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(86, 386);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 7;
            label2.Text = "AIRCRAFT MENU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(371, 386);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 8;
            label3.Text = "LOCATION MENU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(621, 386);
            label4.Name = "label4";
            label4.Size = new Size(211, 28);
            label4.TabIndex = 9;
            label4.Text = "RESERVATION MENU";
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(912, 621);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aircrftBtn);
            Controls.Add(locBtn);
            Controls.Add(reservBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPanel";
            Text = "Flight Reservation App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button reservBtn;
        private Button locBtn;
        private Button aircrftBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
