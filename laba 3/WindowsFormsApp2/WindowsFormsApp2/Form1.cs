using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_class;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Class_arifm res = new Class_arifm(0);
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = ((int)numericUpDown3.Value);
            int first_elem = ((int)numericUpDown1.Value);
            int step = ((int)numericUpDown2.Value);

            res = new Class_arifm(count);
            res.Step = step;
            res.Num = first_elem;
            res.array_value();
            textBox1.Text = "";

            for(int i = 0; i < res.return_elements().Length; i++)
            {
                textBox1.Text += res.return_elements()[i] + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] result = res.return_elements();
            MessageBox.Show($"Значення {((int)numericUpDown4.Value)} - го елемента послідовності: {result[((int)numericUpDown4.Value)-1]}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] result_sum = res.return_elements();
            int sum = 0;
            for(int i=0; i < result_sum.Length; i++)
            {
                sum += result_sum[i];
            }
            MessageBox.Show($"Сума арифметичної послідовності: {sum}");
        }
    }
}
