namespace MagicDatesApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker1.Value;

            int day = chosenDate.Day;
            int month = chosenDate.Month;
            int year = chosenDate.Year;          

            int finalTwoDigits = year %= 100;

            // Check if it is magic number 

            if (day + month == finalTwoDigits)
            {
                lbl_magic.Text = "Magic number!";
                lbl_magic.ForeColor = Color.DarkOrange;                

            }
            else
            {
                lbl_magic.Text = "This looks like an ordinary date.";
                lbl_magic.ForeColor = Color.Black;
            }

            // update the other labels  
            lbl_day.Text = $"Day: {day}";
            lbl_month.Text = $"Month: {month}";
            lbl_year.Text = $"Year: {finalTwoDigits}";
            lbl_sum.Text = $"Sum: {day + month}";
        }
    }
}
