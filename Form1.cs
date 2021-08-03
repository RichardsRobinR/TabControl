using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
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

        private void Fact_Number_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fact_Result_Button_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.Fact_Number_TextBox.Text);
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            this.Fact_Result_TextBox.Text = fact.ToString();
        }

        private void Prime_Result_Button_Click(object sender, EventArgs e)
        {
            
            int p = 0;
            int number = int.Parse(this.Prime_Number_TextBox.Text);
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    p++;
                }

            }
            if (p == 2)
            {

                this.Prime_Result_TextBox.Text = "Prime";
             }
            else
            {
                this.Prime_Result_TextBox.Text = "Not Prime";

            }
            

        }

        private void Fib_Result_Button_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.Fib_Number_TextBox.Text);
            int f1 = 0;
            int f2 = 1;
            int f3;

           
            this.Fib_Result_TextBox.Text = f1 + f2.ToString();
            for (int i = 0; i < num - 2; i++)
            {
                f3 = f1 + f2;
               
                this.Fib_Result_TextBox.Text = this.Fib_Result_TextBox.Text + f3;
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
