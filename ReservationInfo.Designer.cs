namespace FlightReservationApp
{
    partial class ReservationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
            comboAircraft = new ComboBox();
            lblAircraft = new Label();
            comboLocation = new ComboBox();
            lblLocation = new Label();
            lblDate = new Label();
            dateTimePicker = new DateTimePicker();
            txtSurname = new TextBox();
            txtName = new TextBox();
            lblSurname = new Label();
            lblGender = new Label();
            comboGender = new ComboBox();
            lblName = new Label();
            lblIDCard = new Label();
            txtIDCard = new MaskedTextBox();
            dataGridViewReservation = new DataGridView();
            panelList = new Panel();
            btnSave = new Button();
            comboLocation2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            SuspendLayout();
            // 
            // comboAircraft
            // 
            comboAircraft.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAircraft.FormattingEnabled = true;
            comboAircraft.IntegralHeight = false;
            comboAircraft.Location = new Point(134, 39);
            comboAircraft.Margin = new Padding(3, 4, 3, 4);
            comboAircraft.MaxDropDownItems = 4;
            comboAircraft.Name = "comboAircraft";
            comboAircraft.Size = new Size(171, 28);
            comboAircraft.TabIndex = 9;
            // 
            // lblAircraft
            // 
            lblAircraft.AutoSize = true;
            lblAircraft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAircraft.Location = new Point(15, 42);
            lblAircraft.Name = "lblAircraft";
            lblAircraft.Size = new Size(82, 20);
            lblAircraft.TabIndex = 8;
            lblAircraft.Text = "AIRCRAFT";
            // 
            // comboLocation
            // 
            comboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation.FormattingEnabled = true;
            comboLocation.IntegralHeight = false;
            comboLocation.Location = new Point(134, 75);
            comboLocation.Margin = new Padding(3, 4, 3, 4);
            comboLocation.MaxDropDownItems = 4;
            comboLocation.Name = "comboLocation";
            comboLocation.Size = new Size(421, 28);
            comboLocation.TabIndex = 11;
            comboLocation.SelectedIndexChanged += comboLocation_SelectedIndexChanged;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLocation.Location = new Point(15, 79);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(95, 20);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "DEPARTURE";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDate.Location = new Point(600, 111);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 20);
            lblDate.TabIndex = 12;
            lblDate.Text = "DATE";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(696, 109);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 27);
            dateTimePicker.TabIndex = 13;
            dateTimePicker.Value = new DateTime(2024, 6, 4, 21, 15, 0, 724);
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(696, 35);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(228, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(384, 40);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 27);
            txtName.TabIndex = 3;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSurname.Location = new Point(600, 43);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(83, 20);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "SURNAME";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGender.Location = new Point(600, 78);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "GENDER";
            // 
            // comboGender
            // 
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.FormattingEnabled = true;
            comboGender.IntegralHeight = false;
            comboGender.Items.AddRange(new object[] { "", "Female", "Male" });
            comboGender.Location = new Point(696, 70);
            comboGender.Margin = new Padding(3, 4, 3, 4);
            comboGender.MaxDropDownItems = 4;
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(228, 28);
            comboGender.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.Location = new Point(324, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 2;
            lblName.Text = "NAME";
            // 
            // lblIDCard
            // 
            lblIDCard.AutoSize = true;
            lblIDCard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIDCard.Location = new Point(1021, 42);
            lblIDCard.Name = "lblIDCard";
            lblIDCard.Size = new Size(70, 20);
            lblIDCard.TabIndex = 0;
            lblIDCard.Text = "ID CARD";
            // 
            // txtIDCard
            // 
            txtIDCard.Location = new Point(979, 71);
            txtIDCard.Margin = new Padding(3, 4, 3, 4);
            txtIDCard.Mask = "00000000000";
            txtIDCard.Name = "txtIDCard";
            txtIDCard.Size = new Size(171, 27);
            txtIDCard.TabIndex = 1;
            txtIDCard.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Location = new Point(12, 147);
            dataGridViewReservation.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.RowHeadersWidth = 51;
            dataGridViewReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservation.Size = new Size(1149, 267);
            dataGridViewReservation.TabIndex = 15;
            dataGridViewReservation.DataBindingComplete += dataGridViewReservation_DataBindingComplete;
            // 
            // panelList
            // 
            panelList.Location = new Point(62, 422);
            panelList.Margin = new Padding(3, 4, 3, 4);
            panelList.Name = "panelList";
            panelList.Size = new Size(1052, 608);
            panelList.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(979, 108);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "CREATE AND SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboLocation2
            // 
            comboLocation2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation2.FormattingEnabled = true;
            comboLocation2.IntegralHeight = false;
            comboLocation2.Location = new Point(134, 111);
            comboLocation2.Margin = new Padding(3, 4, 3, 4);
            comboLocation2.MaxDropDownItems = 4;
            comboLocation2.Name = "comboLocation2";
            comboLocation2.Size = new Size(421, 28);
            comboLocation2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 111);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 18;
            label1.Text = "DESTINATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(384, 3);
            label2.Name = "label2";
            label2.Size = new Size(358, 28);
            label2.TabIndex = 19;
            label2.Text = "PLEASE CREATE YOUR RESERVATION";
            // 
            // ReservationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1176, 956);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboLocation2);
            Controls.Add(comboAircraft);
            Controls.Add(dateTimePicker);
            Controls.Add(txtSurname);
            Controls.Add(lblDate);
            Controls.Add(btnSave);
            Controls.Add(lblAircraft);
            Controls.Add(txtName);
            Controls.Add(lblLocation);
            Controls.Add(comboLocation);
            Controls.Add(lblSurname);
            Controls.Add(panelList);
            Controls.Add(lblGender);
            Controls.Add(dataGridViewReservation);
            Controls.Add(comboGender);
            Controls.Add(lblName);
            Controls.Add(lblIDCard);
            Controls.Add(txtIDCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationInfo";
            Text = "Reservation Page";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboAircraft;
        private Label lblAircraft;
        private ComboBox comboLocation;
        private Label lblLocation;
        private Label lblDate;
        private DateTimePicker dateTimePicker;
        private Label lblIDCard;
        private MaskedTextBox txtIDCard;
        private Label lblSurname;
        private Label lblGender;
        private ComboBox comboGender;
        private Label lblName;
        private DataGridView dataGridViewReservation;
        private Panel panelList;
        private Button btnSave;
        private TextBox txtSurname;
        private TextBox txtName;
        private ComboBox comboLocation2;
        private Label label1;
        private Label label2;
    }
}