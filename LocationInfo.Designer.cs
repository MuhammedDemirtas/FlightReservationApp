namespace FlightReservationApp
{
    partial class LocationInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationInfo));
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dataGridViewLocation = new DataGridView();
            lblActivePassive = new Label();
            lblAirport = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            comboCountry = new ComboBox();
            comboCity = new ComboBox();
            comboAirport = new ComboBox();
            comboActivePassive = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocation).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(107, 332);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 69);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(107, 409);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 69);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(107, 255);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 69);
            btnSave.TabIndex = 8;
            btnSave.Text = "CREATE AND SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewLocation
            // 
            dataGridViewLocation.AllowUserToAddRows = false;
            dataGridViewLocation.AllowUserToDeleteRows = false;
            dataGridViewLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocation.GridColor = Color.Teal;
            dataGridViewLocation.Location = new Point(311, 38);
            dataGridViewLocation.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLocation.Name = "dataGridViewLocation";
            dataGridViewLocation.ReadOnly = true;
            dataGridViewLocation.RowHeadersWidth = 51;
            dataGridViewLocation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocation.Size = new Size(883, 447);
            dataGridViewLocation.TabIndex = 11;
            dataGridViewLocation.CellClick += dataGridViewLocation_CellClick;
            dataGridViewLocation.DataBindingComplete += dataGridViewLocation_DataBindingComplete;
            // 
            // lblActivePassive
            // 
            lblActivePassive.AutoSize = true;
            lblActivePassive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblActivePassive.Location = new Point(12, 201);
            lblActivePassive.Name = "lblActivePassive";
            lblActivePassive.Size = new Size(89, 20);
            lblActivePassive.TabIndex = 6;
            lblActivePassive.Text = "SITUATION";
            // 
            // lblAirport
            // 
            lblAirport.AutoSize = true;
            lblAirport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAirport.Location = new Point(12, 154);
            lblAirport.Name = "lblAirport";
            lblAirport.Size = new Size(74, 20);
            lblAirport.TabIndex = 4;
            lblAirport.Text = "AIRPORT";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.Location = new Point(12, 111);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(41, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "CITY";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCountry.Location = new Point(12, 68);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 20);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "COUNTRY";
            // 
            // comboCountry
            // 
            comboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCountry.FormattingEnabled = true;
            comboCountry.IntegralHeight = false;
            comboCountry.Location = new Point(107, 60);
            comboCountry.Margin = new Padding(3, 4, 3, 4);
            comboCountry.MaxDropDownItems = 4;
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(198, 28);
            comboCountry.TabIndex = 1;
            comboCountry.SelectedIndexChanged += comboCountry_SelectedIndexChanged;
            // 
            // comboCity
            // 
            comboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCity.FormattingEnabled = true;
            comboCity.IntegralHeight = false;
            comboCity.Location = new Point(107, 111);
            comboCity.Margin = new Padding(3, 4, 3, 4);
            comboCity.MaxDropDownItems = 4;
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(198, 28);
            comboCity.TabIndex = 3;
            comboCity.SelectedIndexChanged += comboCity_SelectedIndexChanged;
            // 
            // comboAirport
            // 
            comboAirport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAirport.FormattingEnabled = true;
            comboAirport.IntegralHeight = false;
            comboAirport.Location = new Point(107, 154);
            comboAirport.Margin = new Padding(3, 4, 3, 4);
            comboAirport.MaxDropDownItems = 4;
            comboAirport.Name = "comboAirport";
            comboAirport.Size = new Size(198, 28);
            comboAirport.TabIndex = 5;
            // 
            // comboActivePassive
            // 
            comboActivePassive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboActivePassive.FormattingEnabled = true;
            comboActivePassive.IntegralHeight = false;
            comboActivePassive.Items.AddRange(new object[] { "", "Active", "Passive" });
            comboActivePassive.Location = new Point(107, 201);
            comboActivePassive.Margin = new Padding(3, 4, 3, 4);
            comboActivePassive.MaxDropDownItems = 4;
            comboActivePassive.Name = "comboActivePassive";
            comboActivePassive.Size = new Size(198, 28);
            comboActivePassive.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(411, 6);
            label1.Name = "label1";
            label1.Size = new Size(348, 28);
            label1.TabIndex = 12;
            label1.Text = "PLEASE CREATE OR EDIT LOCATION";
            // 
            // LocationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1206, 501);
            Controls.Add(label1);
            Controls.Add(comboActivePassive);
            Controls.Add(comboAirport);
            Controls.Add(comboCity);
            Controls.Add(comboCountry);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewLocation);
            Controls.Add(lblActivePassive);
            Controls.Add(lblAirport);
            Controls.Add(lblCity);
            Controls.Add(lblCountry);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "LocationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Location Page";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dataGridViewLocation;
        private Label lblActivePassive;
        private Label lblAirport;
        private Label lblCity;
        private Label lblCountry;
        private ComboBox comboCountry;
        private ComboBox comboCity;
        private ComboBox comboAirport;
        private ComboBox comboActivePassive;
        private Label label1;
    }
}