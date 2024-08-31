using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{


    public partial class Form14NetworkClient : Form
    {
        ChatClass chatClass = new ChatClass();
        System.Diagnostics.Process process;
        public Form14NetworkClient()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chatClass.Send(serverTB.Text, messageTB.Text));
            //messageTB.Text = string.Empty;
            messageTB.Focus();
        }

        private void Form14NetworkClient_Load(object sender, EventArgs e)
        {
            process = System.Diagnostics.Process.Start("ChatServer1");
        }

        //Enter key
        private void serverTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                messageTB.Focus();
        }

        private void messageTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                sendBtn.Focus();
        }

        private void Form14NetworkClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            process.Kill();
        }
    }
}
