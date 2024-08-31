namespace CharsForms
{
    //Properties
    //Right click on the windows designer
    //1.Set Icon
    //2.Set FormBorderStyle to none
    //3.Set StartPosition: The window's default position on program running
    //4.Set Size
    //5.Set BackgroundImage

    //Click the lightning icon in the window to add events
    //1.Double click 'Click' to add am event with a default name
    //2.Load
    //3.FormClosing


    //MDI windows: Multiple-Document interface
    //The container is MidParent, others are child
    //1.Set isMidContainer to True
    //2.Use LayoutMdi to set the layout: Cascade, TileHorizontal, TileVertical

    public partial class Form1MDI : Form
    {
        public Form1MDI()
        {
            InitializeComponent();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZhaWenTing");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Introduction");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to close the window?", "Warn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void addChildWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2WinInheritence form2 = new Form2WinInheritence();
            form2.Show();
            form2.MdiParent = this;

            Form3Tools form3 = new Form3Tools();
            form3.Show();
            form3.MdiParent = this;

            Form4AdvancedTools form4 = new Form4AdvancedTools();
            form4.Show();
            form4.MdiParent = this;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

       

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
