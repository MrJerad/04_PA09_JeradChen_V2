using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PA9_JeradChen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedvalue;
            //checking for null values
            
            if((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked == false))
            {
                txt_value.Text = "Select at least one type of currency to convert";
            }

            // convert SGD to US dollars
            if(rdb_USdollars.Checked == true)
            {
                try
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;
                    txt_value.Text = convertedvalue.ToString();
                }
                catch (FormatException)
                {
                    txt_value.Text = "Invalid Input";
                }
            }

            if(rdb_JapaneseYen.Checked == true)
            {
                try
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;
                    txt_value.Text = convertedvalue.ToString();
                }
                catch (FormatException)
                {
                    txt_value.Text = "Invalid Input";
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_value.Text = "";
            rdb_JapaneseYen.Checked = false;
            rdb_USdollars.Checked = false;
        }
    }
}
