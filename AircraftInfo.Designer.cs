namespace FlightReservationApp
{
    partial class AircraftInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AircraftInfo));
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dataGridViewAircraft = new DataGridView();
            txtSeatCapacity = new MaskedTextBox();
            txtSeriNumber = new TextBox();
            txtTrademark = new TextBox();
            txtModel = new TextBox();
            lblSeatCapacity = new Label();
            lblSeriNumber = new Label();
            lblTrademark = new Label();
            lblModel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAircraft).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(102, 303);
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
            btnUpdate.Location = new Point(102, 380);
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
            btnSave.Location = new Point(102, 226);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 69);
            btnSave.TabIndex = 8;
            btnSave.Text = "CREATE AND SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewAircraft
            // 
            dataGridViewAircraft.AllowUserToAddRows = false;
            dataGridViewAircraft.AllowUserToDeleteRows = false;
            dataGridViewAircraft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAircraft.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAircraft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAircraft.Location = new Point(320, 40);
            dataGridViewAircraft.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAircraft.Name = "dataGridViewAircraft";
            dataGridViewAircraft.ReadOnly = true;
            dataGridViewAircraft.RowHeadersWidth = 51;
            dataGridViewAircraft.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAircraft.Size = new Size(898, 422);
            dataGridViewAircraft.TabIndex = 11;
            dataGridViewAircraft.CellClick += dataGridViewAircraft_CellClick;
            dataGridViewAircraft.DataBindingComplete += dataGridViewAircraft_DataBindingComplete;
            // 
            // txtSeatCapacity
            // 
            txtSeatCapacity.Location = new Point(137, 191);
            txtSeatCapacity.Margin = new Padding(3, 4, 3, 4);
            txtSeatCapacity.Mask = "0000";
            txtSeatCapacity.Name = "txtSeatCapacity";
            txtSeatCapacity.Size = new Size(171, 27);
            txtSeatCapacity.TabIndex = 7;
            txtSeatCapacity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSeriNumber
            // 
            txtSeriNumber.Location = new Point(137, 156);
            txtSeriNumber.Margin = new Padding(3, 4, 3, 4);
            txtSeriNumber.Name = "txtSeriNumber";
            txtSeriNumber.Size = new Size(171, 27);
            txtSeriNumber.TabIndex = 5;
            // 
            // txtTrademark
            // 
            txtTrademark.Location = new Point(137, 124);
            txtTrademark.Margin = new Padding(3, 4, 3, 4);
            txtTrademark.Name = "txtTrademark";
            txtTrademark.Size = new Size(171, 27);
            txtTrademark.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(137, 86);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(171, 27);
            txtModel.TabIndex = 1;
            // 
            // lblSeatCapacity
            // 
            lblSeatCapacity.AutoSize = true;
            lblSeatCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSeatCapacity.Location = new Point(3, 191);
            lblSeatCapacity.Name = "lblSeatCapacity";
            lblSeatCapacity.Size = new Size(119, 20);
            lblSeatCapacity.TabIndex = 6;
            lblSeatCapacity.Text = "SEAT CAPACITY";
            // 
            // lblSeriNumber
            // 
            lblSeriNumber.AutoSize = true;
            lblSeriNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSeriNumber.Location = new Point(3, 156);
            lblSeriNumber.Name = "lblSeriNumber";
            lblSeriNumber.Size = new Size(128, 20);
            lblSeriNumber.TabIndex = 4;
            lblSeriNumber.Text = "SERIAL NUMBER";
            // 
            // lblTrademark
            // 
            lblTrademark.AutoSize = true;
            lblTrademark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTrademark.Location = new Point(3, 124);
            lblTrademark.Name = "lblTrademark";
            lblTrademark.Size = new Size(103, 20);
            lblTrademark.TabIndex = 2;
            lblTrademark.Text = "TRADEMARK";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblModel.Location = new Point(3, 89);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(61, 20);
            lblModel.TabIndex = 0;
            lblModel.Text = "MODEL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(445, 8);
            label1.Name = "label1";
            label1.Size = new Size(343, 28);
            label1.TabIndex = 13;
            label1.Text = "PLEASE CREATE OR EDIT AIRCRAFT";
            // 
            // AircraftInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1230, 483);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewAircraft);
            Controls.Add(txtSeatCapacity);
            Controls.Add(txtSeriNumber);
            Controls.Add(txtTrademark);
            Controls.Add(txtModel);
            Controls.Add(lblSeatCapacity);
            Controls.Add(lblSeriNumber);
            Controls.Add(lblTrademark);
            Controls.Add(lblModel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AircraftInfo";
            Text = "Aircraft Page";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAircraft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dataGridViewAircraft;
        private MaskedTextBox txtSeatCapacity;
        private TextBox txtSeriNumber;
        private TextBox txtTrademark;
        private TextBox txtModel;
        private Label lblSeatCapacity;
        private Label lblSeriNumber;
        private Label lblTrademark;
        private Label lblModel;
        private Label label1;
    }
}