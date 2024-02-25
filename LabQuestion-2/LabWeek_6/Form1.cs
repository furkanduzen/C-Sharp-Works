using System.Diagnostics.Metrics;

namespace LabWeek_6
{
    public partial class Form1 : Form
    {
        int counter = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnStartTimer.Location = new Point(rnd.Next(0, Size.Width), rnd.Next(0, Size.Height));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            lblCountDown.Text = counter.ToString();
            progressBar1.Value = progressBar1.Value + 1 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value + 1;
            if (counter <= 0)
            {
                timer2.Stop();
                timer1.Stop();
                MessageBox.Show("Game is Over!!!");
                return;
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Congratulations! You stopped it.");
            }
        }
    }
}