/* cTree Date Converter
 * Author:              Caleb Anderson
 * email address:       Caleb.Anderson@HenrySchein.com
 * Description:         Some reports and utilities give dates as a large integer.  These dates are not easily 
 *                      understood.  As such, this utility will take a date in the long integer format and return
 *                      a date in a more conventional format.
 * Initial Features:    
 *          - Feature 1: Converts dates from numeric format to a more readable format.
 */


using System;
using System.Windows.Forms;

namespace c_Tree_Date_Converter
{
    public partial class Form1 : Form
    {
        DateTime _startDate = new DateTime(1700, 2, 28); //default start date for c-Tree

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertIt_Click(object sender, EventArgs e)
        {
            //The number can be larger than what can be stored as an int32.  To compensate, use the double data type.
            double addDays;
            if (double.TryParse(tbDateToConvert.Text.Trim(), out addDays))
                //if the textbox parses, add the number of days listed in the TextBox to the default start date for c-Tree
                lblConvertedDate.Text = _startDate.AddDays(addDays).ToShortDateString();
            else
                //if it doesn't parse, provide error message.
                MessageBox.Show(
                        "Please enter a valid number", 
                        "Invalid C-Tree Date Format", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }
    }
}
