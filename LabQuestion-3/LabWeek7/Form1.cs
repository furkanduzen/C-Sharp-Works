namespace LabWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manage_button_checkboxes(object sender, EventArgs e)
        {
            CheckBox chcSender = (CheckBox)sender;
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            foreach (var item in Controls)
                if (item is Button)
                {
                    Button btnItem = (Button)item;
                    if (btnItem.Text == chcSender.Text)
                        if (chcSender.Checked)
                            btnItem.BackColor = randomColor;
                        else
                            btnItem.BackColor = Control.DefaultBackColor;
                }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var comp in Controls)
            {
                if (comp is Button)
                {
                    Button btn1 = (Button)comp;
                    btn1.Text = rnd.Next(1, 6).ToString();
                }
            }
        }
    }
}