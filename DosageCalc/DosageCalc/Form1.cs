using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosageCalc
{
    
    public partial class Dosage_Calculator : Form
    {
        public Dosage_Calculator()
        {
            InitializeComponent();
        }
        double Weight;
        //Calc function
        double Calc(double Weight)
        {
            double KG = (Weight * 0.453592f);
            if (listBox1.SelectedItem == "DXM/Dextromethorphan")
                return (KG * 250);
            else if (listBox1.SelectedItem == "Caffiene")
                return (KG * 175);
            else if (listBox1.SelectedItem == "Amphetamine")
                return (KG * 22.5);
            else if (listBox1.SelectedItem == "Alprazolam/Xanax")
                return (KG * 1085.5);
            else if (listBox1.SelectedItem == "LSD")
                return (KG * 20);
            else if (listBox1.SelectedItem == "Psilocybin")
                return (KG * 12.5);
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WeightInput_TextChanged(object sender, EventArgs e)
        {
            if(WeightInput.Text.Length > 0)
                Weight = Convert.ToDouble(WeightInput.Text);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DosageOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            if (Weight > 300)
            {
                MessageBox.Show("Lose weight, fatty!");
            }
            else
            {
                DosageOutput.Text = Calc(Weight).ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
