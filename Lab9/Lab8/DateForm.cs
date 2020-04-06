//By: Ross Doherty ID: N7701
//Due Date: 4/21/2019
//CIS 199-75
//Defaults date to 01/01/2000. Then allows user to manipulate date by entering a month, day and/or year value


using System;
using System.Windows.Forms;

namespace Lab8
{
    public partial class DateForm : Form
    {
        Date dt = new Date(1, 1, 2000);//date object with default values.
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            
            dateText.Text = dt.ToString();//use the default values when the form is loaded.
        }
        //
        private void updateMonth_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt16(mnth.Text);//month value to be updated
            dt.SetMonth(m);//call the set function for month.
            dateText.Text = dt.ToString();//display the month in the date text box.
        }

        private void updateDay_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(dy.Text);//day value to be updated
            dt.SetDay(d);//call the set function for day.
            dateText.Text = dt.ToString();//display the day in the date text box.
        }

        private void updateYear_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt16(yr.Text);//year value to be updated
            dt.SetYear(y);//call the set function for year.
            dateText.Text = dt.ToString();//display the year in the date text box.
        }
    }
}
