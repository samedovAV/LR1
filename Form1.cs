using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split(new char[] { ';' });
            int[] nums = new int[10];
            for (int i =0;i<10;i++)
            {
                // Проверка на количество чисел в числе
                if(text[i].Length != 4)
                {
                    MessageBox.Show("Error");
                    return;
                }
                else
                {
                    nums[i] = int.Parse(text[i]);
                }             
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
