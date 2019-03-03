using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("请选择一种换行设置！");
                return;
            }
            if (checkBox1.Checked && textBox1.Text=="")
            {
                MessageBox.Show("请设置长度！");
                return;
            }
            if (checkBox1.Checked && int.Parse(textBox1.Text) == 0)
            {
                MessageBox.Show("请设置长度！");
                return;
            }
            if (checkBox2.Checked && textBox2.Text == "")
            {
                MessageBox.Show("请设置特殊符号！");
                return;
            }
            if (checkBox2.Checked && textBox2.Text.Length > 2)
            {
                MessageBox.Show("请设置正确的特殊符号！");
                return;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.DialogResult = DialogResult.No;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
//             if (!checkBox1.Checked)
//             {
//                 textBox1.Enabled = false;
//             } 
//             else
//             {
//                 textBox1.Enabled = true;
//             }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
//             if (!checkBox2.Checked)
//             {
//                 textBox2.Enabled = false;
//             }
//             else
//             {
//                 textBox2.Enabled = true;
//             }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0'|| e.KeyChar>'9')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
