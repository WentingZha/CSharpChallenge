namespace ChatServer1
{
    public partial class Form1 : Form
    {
        ChatClass chatClass = new ChatClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            chatClass.StartListener();
            this.Close();

        }
    }
}