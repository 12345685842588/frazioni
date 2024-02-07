using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frazioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f1=Fraction.Parse(textBox1.Text);
            Fraction f2=Fraction.Parse(textBox2.Text);
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();

            label1.Text=f1.Somma(f2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction somma=new Fraction(0,1);

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                
            }
           
        }

        
    }
}
