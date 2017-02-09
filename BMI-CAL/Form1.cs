using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && textBox1.Text != "" && textBox2.Text != "" && Convert.ToDouble(textBox1.Text) > 0 && Convert.ToDouble(textBox2.Text) > 0)
            {
                double masa = Convert.ToDouble(textBox1.Text);
                double wzrost = Convert.ToDouble(textBox2.Text)/100;
                double BMI = masa / (wzrost*wzrost)  ;

                if (comboBox1.SelectedItem == "Kobieta")
                {
                    //label2.Text = Convert.ToString(BMI);
                    if (BMI < 18) label2.Text = "Niedowaga !!!";
                    else if (BMI < 24.99) label2.Text = "Waga Prawidłowa";
                    else label2.Text = "Nadwaga !!!";
                    //< 18,5 – niedowagę
                    //18,5–24,99 – wartość prawidłową
                    //≥ 25,0 – nadwagę
                 
                }
                else
                {
                    if (BMI < 18) label2.Text = "Niedowaga !!!";
                    else if (BMI < 24.99) label2.Text = "Waga Prawidłowa";
                    else label2.Text = "Nadwaga !!!";
                }
            }
            else label2.Text = "Nie wypelniles poprawnie wymaganych pol";
           
        
        }
    }
}
