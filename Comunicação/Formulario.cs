using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Add(textBox3.Text);
            }
            {
                listBox1.Items.Add(DateTime.Now.Date.ToShortDateString());
                listBox1.Items.Add(DateTime.Now.TimeOfDay.ToString());
            }
}
    }
}
