using System;
using System.Windows.Forms;

namespace AboutTest
{
    public partial class Form1 : Form
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_CONTEXTHELP = 0xf180;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Capture = false;
            SendMessage(this.Handle, WM_SYSCOMMAND, (IntPtr)SC_CONTEXTHELP, IntPtr.Zero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }
    }
}
