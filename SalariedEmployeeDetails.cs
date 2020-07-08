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
    public partial class SalariedEmployeeDetails : Form
    {
        SalariedEmployee salariedEmployee = new SalariedEmployee();
        public SalariedEmployeeDetails()
        {
            InitializeComponent();
        }

        private void SalariedEmployeeDetails_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = salariedEmployeeDetails.FirstName;
            LastNameTextBox.Text = salariedEmployeeDetails.LastName;
            AddressTextBox.Text = salariedEmployeeDetails.Address;
            PostCodeTextBox.Text = salariedEmployeeDetails.PostCode;
            PhoneNumberTextBox.Text = salariedEmployeeDetails.PhoneNumber;
            //On date of birth I'm doing the same thing as in the hourly employee class by adding the 
            //value of the date.
            DateOfBirthPicker.Text = salariedEmployee.DateOfBirth.ToString("1,1,1753");
            AnnualSalaryTextBox.Text = salariedEmployeeDetails.Salary.ToString() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            salariedEmployee = new SalariedEmployee(FirstNameTextBox.Text, LastNameTextBox.Text,
                AddressTextBox.Text, PostCodeTextBox.Text, PhoneNumberTextBox.Text,
                new DateTime(DateOfBirthPicker.Value.Year, DateOfBirthPicker.Value.Month, 
                DateOfBirthPicker.Value.Day), decimal.Parse (AnnualSalaryTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        public SalariedEmployee salariedEmployeeDetails
        {
            get
            {
                return salariedEmployee;
            }
            set
            {
                salariedEmployee = value;
            }
        }
    }
}
