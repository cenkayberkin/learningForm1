using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learningForm1
{
    public partial class LifeCycle : Form
    {
        public LifeCycle()
        {
            InitializeComponent();
        }

        private void LifeCycle_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Oranges");
            listBox1.Items.Add("Grapes");
            listBox1.Items.Add("Bananas");
            listBox1.Items.Add("Peaches");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
        }
    }
}
