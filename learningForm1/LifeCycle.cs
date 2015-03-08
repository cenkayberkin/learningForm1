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
            if (listBox1.SelectedIndex == -1)
            {
                string msg = "Please select an item from the list box";
                MessageBox.Show(msg, this.Text);
            }
            label1.Text = listBox1.Text;
        }

        private void LifeCycle_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmDialog cdialog = new ConfirmDialog();
            if (cdialog.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }

            //string msg = "Are you sure want to close?";
            //if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
