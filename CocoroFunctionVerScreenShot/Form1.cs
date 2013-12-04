using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocoroFunctionVerScreenShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Visible = false;
            Program.Closing();
//            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenShot.Shot();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            TopMost = false;
        }

    }
}
