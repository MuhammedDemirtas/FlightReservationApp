using FlightReservationApp.Models;

namespace FlightReservationApp
{
    public partial class AircraftInfo : Form
    {
        private DBContext context = new DBContext();

        public AircraftInfo()
        {
            InitializeComponent();
            datas();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                Aircraft aircraft = new Aircraft
                {
                    AircraftModel = txtModel.Text,
                    ACTrademark = txtTrademark.Text,
                    ACSerialNumber = txtSeriNumber.Text,
                    ACSeatCapacity = int.Parse(txtSeatCapacity.Text)
                };
                context.Aircrafts.Add(aircraft);
                context.SaveChanges();
                datas();
                clearDatas();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                if (dataGridViewAircraft.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewAircraft.SelectedRows[0].Cells[0].Value.ToString());
                    Aircraft aircraft = context.Aircrafts.Find(id);
                    if (aircraft != null)
                    {
                        aircraft.AircraftModel = txtModel.Text;
                        aircraft.ACTrademark = txtTrademark.Text;
                        aircraft.ACSerialNumber = txtSeriNumber.Text;
                        aircraft.ACSeatCapacity = int.Parse(txtSeatCapacity.Text);
                        context.SaveChanges();
                        datas();
                        clearDatas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                if (dataGridViewAircraft.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewAircraft.SelectedRows[0].Cells[0].Value.ToString());
                    Aircraft aircraft = context.Aircrafts.Find(id);
                    if (aircraft != null)
                    {
                        context.Aircrafts.Remove(aircraft);
                        context.SaveChanges();
                        datas();
                        clearDatas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAircraft_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.DbCheck())
            {
                dataGridViewAircraft.Columns[0].HeaderText = "Aircraft ID";
                dataGridViewAircraft.Columns[1].HeaderText = "Model";
                dataGridViewAircraft.Columns[2].HeaderText = "Trademark";
                dataGridViewAircraft.Columns[3].HeaderText = "Serial Number";
                dataGridViewAircraft.Columns[4].HeaderText = "Seat Capacity";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAircraft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DBContext.DbCheck())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewAircraft.Rows[e.RowIndex];
                    txtModel.Text = row.Cells["AircraftModel"].Value.ToString();
                    txtTrademark.Text = row.Cells["ACTrademark"].Value.ToString();
                    txtSeriNumber.Text = row.Cells["ACSerialNumber"].Value.ToString();
                    txtSeatCapacity.Text = row.Cells["ACSeatCapacity"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datas()
        {
            if (DBContext.DbCheck())
            {
                dataGridViewAircraft.DataSource = context.Aircrafts.ToList();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDatas()
        {
            txtModel.Text = null;
            txtTrademark.Text = null;
            txtSeriNumber.Text = null;
            txtSeatCapacity.Text = null;
        }
    }
}
