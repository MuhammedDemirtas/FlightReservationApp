namespace FlightReservationApp
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocationInfo form = new LocationInfo();
            form.Show();

        }

        private void aircrftBtn_Click(object sender, EventArgs e)
        {
            AircraftInfo form = new AircraftInfo();
            form.Show();
        }

        private void reservBtn_Click(object sender, EventArgs e)
        {
            ReservationInfo form = new ReservationInfo();
            form.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
