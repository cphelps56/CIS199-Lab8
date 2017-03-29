// Name: Colin Phelps
// Lab 8
// Due Date: 4/21/15
// CIS 199-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class DateForm : Form
    {
        // New date object is filled with 1/1/2001.
        private Date date = new Date(1, 1, 2001);

        public DateForm()
        {
            InitializeComponent();
        }

        // Precondition: The form is loaded.
        // Postcondition: The date is displayed in a label.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Displays the date.
            dateLabel.Text = date.ToString();
        }

        // Precondition: The Update Month button is clicked.
        // Postcondition: The month number is updated if it is 1-12, and the textbox is cleared.
        private void updateMonthBtn_Click(object sender, EventArgs e)
        {
            int newMonth; // Holds the integer entered in the month textbox.

            if(int.TryParse(monthTxtBox.Text, out newMonth))
            {
                // Changes the month to the month entered in the textbox.
                date.Month = newMonth;
                // Displays the new date.
                dateLabel.Text = date.ToString();
                // Clears the textbox.
                monthTxtBox.Clear();
            }

        }

        // Precondition: The Update Day button is clicked.
        // Postcondition: The day is updated if it is 1-31, and the textbox is cleared.
        private void updateDayBtn_Click(object sender, EventArgs e)
        {
            int newDay; // Holds the integer in the day textbox.

            if (int.TryParse(dayTxtBox.Text, out newDay))
            {
                date.Day = newDay;
                dateLabel.Text = date.ToString();
                dayTxtBox.Clear();
            }
        }

        // Precondition: The Update Year button is clicked.
        // Postcondition: The year is updated if it is above 0, and the textbox is cleared.
        private void updateYearBtn_Click(object sender, EventArgs e)
        {
            int newYear; // Holds the integer in the year textbox.
           
            if (int.TryParse(yearTxtBox.Text, out newYear))
            {
                date.Year = newYear;
                dateLabel.Text = date.ToString();
                yearTxtBox.Clear();
            }
        }

    }
}
