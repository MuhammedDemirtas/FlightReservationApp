using FlightReservationApp.Models;
using System.Diagnostics.Metrics;

namespace FlightReservationApp
{
    public partial class LocationInfo : Form
    {
        private DBContext context = new DBContext();

        public LocationInfo()
        {
            InitializeComponent();
            datas();

            var country = lokasyonlar.Select(l => l.Country).Distinct().ToList();
            comboCountry.DataSource = country;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                bool situation = false;
                if (comboActivePassive.SelectedItem.ToString() == "Active")
                    situation = true;
                Location location = new Location
                {
                    Country = comboCountry.SelectedItem.ToString(),
                    City = comboCity.SelectedItem.ToString(),
                    Airport = comboAirport.SelectedItem.ToString(),
                    Situation = situation
                };
                context.Locations.Add(location);
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
                if (dataGridViewLocation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewLocation.SelectedRows[0].Cells[0].Value.ToString());
                    Location location = context.Locations.Find(id);
                    if (location != null)
                    {
                        bool situation = false;
                        if (comboActivePassive.SelectedItem.ToString() == "Active")
                            situation = true;
                        location.Country = comboCountry.SelectedItem.ToString();
                        location.City = comboCity.SelectedItem.ToString();
                        location.Airport = comboAirport.SelectedItem.ToString();
                        location.Situation = situation;
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
                if (dataGridViewLocation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewLocation.SelectedRows[0].Cells[0].Value.ToString());
                    Location location = context.Locations.Find(id);
                    if (location != null)
                    {
                        context.Locations.Remove(location);
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


        private void dataGridViewLocation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.DbCheck())
            {
                dataGridViewLocation.Columns[0].HeaderText = "Location ID";
                dataGridViewLocation.Columns[1].HeaderText = "Country";
                dataGridViewLocation.Columns[2].HeaderText = "City";
                dataGridViewLocation.Columns[3].HeaderText = "Airport";
                dataGridViewLocation.Columns[4].HeaderText = "Situation";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dataGridViewLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DBContext.DbCheck())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewLocation.Rows[e.RowIndex];
                    comboCountry.SelectedItem = row.Cells["Country"].Value.ToString();
                    comboCity.SelectedItem = row.Cells["City"].Value.ToString();
                    comboAirport.SelectedItem = row.Cells["Airport"].Value.ToString();
                    if (Convert.ToBoolean(row.Cells["Situation"].Value))
                        comboActivePassive.SelectedItem = "Active";
                    else
                        comboActivePassive.SelectedItem = "Passive";
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                var city = lokasyonlar.Where(l => l.Country == comboCountry.SelectedItem.ToString()).Select(l => l.City).Distinct().ToList();
                comboCity.DataSource = city;
                comboCity.SelectedIndex = -1;
                comboAirport.DataSource = null;
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBContext.DbCheck())
            {
                if (comboCity.SelectedIndex >= 0)
                {
                    var airport = lokasyonlar.Where(l => l.Country == comboCountry.SelectedItem.ToString() && l.City == comboCity.SelectedItem.ToString()).Select(l => l.Airport).Distinct().ToList();
                    comboAirport.DataSource = airport;
                    comboAirport.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<CreateLocation> lokasyonlar = new List<CreateLocation>
        {
            new CreateLocation("", "", ""),
            new CreateLocation("Türkiye", "Adana", "Adana Havalimanı (ADA)"),
            new CreateLocation("Türkiye", "Amasya", "Amasya Merzifon Havalimanı (MZH)"),
            new CreateLocation("Türkiye", "Ankara", "Ankara Esenboğa Havalimanı (ESB)"),
            new CreateLocation("Türkiye", "Antalya", "Antalya Havalimanı (AYT)"),
            new CreateLocation("Türkiye", "Bursa", "Bursa Yenişehir Havalimanı (YEI)"),
            new CreateLocation("Türkiye", "Elazığ", "Elazığ Havalimanı (EZS)"),
            new CreateLocation("Türkiye", "Erzurum", "Erzurum Havalimanı (ERZ)"),
            new CreateLocation("Türkiye", "Eskişehir", "Hasan Polatkan Havalimanı (AOE)"),
            new CreateLocation("Türkiye", "Gaziantep", "Gaziantep Havalimanı (GZT)"),
            new CreateLocation("Türkiye", "İstanbul", "İstanbul Havalimanı (IST)"),
            new CreateLocation("Türkiye", "İstanbul", "Sabiha Gökçen Havalimanı (SAW)"),
            new CreateLocation("Türkiye", "İzmir", "İzmir Adnan Menderes Havalimanı (ADB)"),
            new CreateLocation("Türkiye", "Kahramanmaraş", "Kahramanmaraş Havalimanı (KCM)"),
            new CreateLocation("Türkiye", "Kars", "Kars Harakani Havalimanı (KSY)"),
            new CreateLocation("Türkiye", "Kastamonu", "Kastamonu Havalimanı (KFS)"),
            new CreateLocation("Türkiye", "Kocaeli", "Kocaeli Cengiz Topel Havalimanı (KCO)"),
            new CreateLocation("Türkiye", "Konya", "Konya Havalimanı (KYA)"),
            new CreateLocation("Türkiye", "Muğla-Bodrum", "Milas-Bodrum Havalimanı (BJV)"),
            new CreateLocation("Türkiye", "Ordu-Giresun", "Ordu-Giresun Havalimanı (OGU)"),
            new CreateLocation("Türkiye", "Rize", "Rize Artvin Havalimanı (RZV)"),
            new CreateLocation("Türkiye", "Sinop", "Sinop Havalimanı (NOP)"),
            new CreateLocation("Almanya", "Berlin", "Berlin Brandenburg Havalimanı"),
            new CreateLocation("Almanya", "Münih", "Münih Havalimanı"),
            new CreateLocation("Almanya", "Frankfurt", "Frankfurt Havalimanı"),
            new CreateLocation("Fransa", "Paris", "Charles de Gaulle Havalimanı"),
            new CreateLocation("Fransa", "Lyon", "Lyon Saint-Exupéry Havalimanı"),
            new CreateLocation("Fransa", "Nice", "Nice Côte d'Azur Havalimanı"),
            new CreateLocation("Katar", "Doha", "Hamad Uluslararası Havalimanı"),
            new CreateLocation("Katar", "Al Wakrah", "Al Wakrah Havalimanı"),
            new CreateLocation("Katar", "Al Khor", "Al Khor Havalimanı"),
            new CreateLocation("Amerika", "New York", "John F. Kennedy Uluslararası Havalimanı"),
            new CreateLocation("Amerika", "Los Angeles", "Los Angeles Uluslararası Havalimanı"),
            new CreateLocation("Amerika", "Chicago", "O'Hare Uluslararası Havalimanı"),
            new CreateLocation("İspanya", "Madrid", "Madrid-Barajas Adolfo Suárez Havalimanı"),
            new CreateLocation("İspanya", "Barselona", "Barselona El Prat Havalimanı"),
            new CreateLocation("İspanya", "Palma de Mallorca", "Palma de Mallorca Havalimanı")
        };

        private void datas()
        {
            if (DBContext.DbCheck())
            {
                dataGridViewLocation.DataSource = context.Locations.ToList();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDatas()
        {
            comboCountry.SelectedItem = "";
            comboActivePassive.SelectedItem = "";
        }
    }
}
