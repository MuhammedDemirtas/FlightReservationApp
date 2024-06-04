using FlightReservationApp.Models;

namespace FlightReservationApp
{
    public partial class ReservationInfo : Form
    {
        private DBContext context = new DBContext();
        private int SeatNumber;

        public ReservationInfo()
        {
            InitializeComponent();
            datas();
            aircrafts();
            locations();
            list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                Reservation reservation = new Reservation
                {
                    AircraftId = (int)comboAircraft.SelectedValue,
                    LocationId = (int)comboLocation.SelectedValue,
                    Date = dateTimePicker.Value,
                    CustomerIdCard = txtIDCard.Text,
                    CustomerName = txtName.Text,
                    CustomerSurname = txtSurname.Text,
                    CustomerGender = comboGender.Text,
                    SeatNumber = SeatNumber,
                };
                context.Reservations.Add(reservation);
                context.SaveChanges();
                datas();
                panelList.Controls.Clear();
                list();
                clearDatas();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReservation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.DbCheck())
            {
                dataGridViewReservation.Columns[0].HeaderText = "ID Card";
                dataGridViewReservation.Columns[1].HeaderText = "Name";
                dataGridViewReservation.Columns[2].HeaderText = "Surname";
                dataGridViewReservation.Columns[3].HeaderText = "Gender";
                dataGridViewReservation.Columns[4].HeaderText = "Seat Number";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aircrafts()
        {
            if (DBContext.DbCheck())
            {
                var aircraft = context.Aircrafts.ToList();
                comboAircraft.DataSource = aircraft;
                comboAircraft.DisplayMember = "AircraftModel";
                comboAircraft.ValueMember = "AircraftId";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void locations()
        {
            if (DBContext.DbCheck())
            {
                var location = context.Locations.ToList();
                comboLocation.DataSource = location;
                comboLocation.DisplayMember = "Airport";
                comboLocation.ValueMember = "LocationId";

                var location2 = context.Locations.ToList();
                comboLocation2.DataSource = location2;
                comboLocation2.DisplayMember = "Airport";
                comboLocation2.ValueMember = "LocationId";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list()
        {
            if (DBContext.DbCheck())
            {
                List<int> seats = context.Reservations.Select(r => r.SeatNumber).ToList();

                int x = 30;
                int y = 30;
                int buttonWidth = 75;
                int buttonHeight = 23;
                int tabIndex = 1;

                for (int row = 0; row < 20; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        Button button = new Button();
                        button.Text = $"{tabIndex}";
                        button.Location = new System.Drawing.Point(x, y);
                        button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                        button.TabIndex = tabIndex;
                        if (seats.Contains(tabIndex))
                            button.BackColor = System.Drawing.Color.Red;
                        else
                            button.BackColor = System.Drawing.Color.Green;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Click += button_Click;
                        panelList.Controls.Add(button);

                        x += buttonWidth + 1;
                        tabIndex++;

                        if (col == 2)
                        {
                            x += buttonWidth + 1;
                        }
                    }

                    for (int col = 0; col < 4; col++)
                    {
                        Button button = new Button();
                        button.Text = $"{tabIndex}";
                        button.Location = new System.Drawing.Point(x, y);
                        button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                        button.TabIndex = tabIndex;
                        if (seats.Contains(tabIndex))
                            button.BackColor = System.Drawing.Color.Red;
                        else
                            button.BackColor = System.Drawing.Color.Green;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Click += button_Click;
                        panelList.Controls.Add(button);

                        x += buttonWidth + 1;
                        tabIndex++;

                        if (col == 3)
                        {
                            x += buttonWidth + 1;
                        }
                    }

                    for (int col = 0; col < 3; col++)
                    {
                        Button button = new Button();
                        button.Text = $"{tabIndex}";
                        button.Location = new System.Drawing.Point(x, y);
                        button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                        button.TabIndex = tabIndex;
                        if (seats.Contains(tabIndex))
                            button.BackColor = System.Drawing.Color.Red;
                        else
                            button.BackColor = System.Drawing.Color.Green;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Click += button_Click;
                        panelList.Controls.Add(button);

                        x += buttonWidth + 1;
                        tabIndex++;

                        if (col == 2)
                        {
                            x += buttonWidth + 1;
                        }
                    }

                    x = 30;
                    y += buttonHeight + 1;
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int seat = int.Parse(button.Text);
                SeatNumber = seat;
            }
        }

        private void datas()
        {
            if (DBContext.DbCheck())
            {
                dataGridViewReservation.DataSource = context.Reservations.Select(r => new { r.CustomerIdCard, r.CustomerName, r.CustomerSurname, r.CustomerGender, r.SeatNumber }).ToList();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDatas()
        {
            txtIDCard.Text = null;
            txtName.Text = null;
            txtSurname.Text = null;
            comboGender.SelectedItem = "";
            comboAircraft.SelectedItem = "";
            comboLocation.SelectedItem = "";
            dateTimePicker.Value = DateTime.Now;
        }

        private void comboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
