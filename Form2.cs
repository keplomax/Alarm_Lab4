using System;
using System.Windows.Forms;

namespace Alarm_Lab4
{
    public partial class Form2 : Form
    {
        private object timer;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer_Update(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
