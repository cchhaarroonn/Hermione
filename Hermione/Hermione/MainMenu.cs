namespace Hermione
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage sendMessage = new SendMessage();
            sendMessage.Show(this);
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpamMessage spamMessage = new SpamMessage();
            spamMessage.Show(this);
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}