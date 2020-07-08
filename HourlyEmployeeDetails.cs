using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class HourlyEmployeeDetails : Form
    {
        HourlyEmployee hourlyEmployee = new HourlyEmployee();
        public HourlyEmployeeDetails()
        {
            InitializeComponent();
        }

        private void HourlyEmployeeDetails_Load(object sender, EventArgs e)
        {
            firstNameTextBoxHourly.Text = hourlyEmployeeDetails.FirstName;
            lastNameTextBoxHourly.Text = hourlyEmployeeDetails.LastName;
            addressTextBoxHourly.Text = hourlyEmployeeDetails.Address;
            postCodeTextBoxHourly.Text = hourlyEmployeeDetails.PostCode;
            phoneNumberTextBoxHourly.Text = hourlyEmployeeDetails.PhoneNumber;
            //I'm loading the whole value of the date of birth here!
            dateOfBirthPickerHourly.Text = hourlyEmployee.DateOfBirth.ToString("1,1,1753");
            overTimeTextBoxHourly.Text = hourlyEmployeeDetails.OvertimePay.ToString();
            hourlyPayTextBox.Text = hourlyEmployeeDetails.HourlyPay.ToString();
        }

        private void cancelButtonHourly_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButtonHourly_Click(object sender, EventArgs e)
        {
            hourlyEmployee = new HourlyEmployee(firstNameTextBoxHourly.Text, lastNameTextBoxHourly.Text,
                addressTextBoxHourly.Text, postCodeTextBoxHourly.Text, phoneNumberTextBoxHourly.Text,
                new DateTime(dateOfBirthPickerHourly.Value.Year, dateOfBirthPickerHourly.Value.Month,
                dateOfBirthPickerHourly.Value.Day), decimal.Parse(hourlyPayTextBox.Text), 
                decimal.Parse(overTimeTextBoxHourly.Text));
            DialogResult = DialogResult.OK;
        }

        public HourlyEmployee hourlyEmployeeDetails
        {
            get
            {
                return hourlyEmployee;
            }    
            set
            {
                hourlyEmployee = value;
            }
        }
    }
}
