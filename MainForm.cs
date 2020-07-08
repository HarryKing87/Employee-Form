using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class MainForm : Form 
    {
        // The file used to store employee details
        string employeesFile = "employees.txt";
        
        // The collection used to hold the employee data
        Employees employees;
        SalariedEmployeeDetails salariedEmployeeDetails;
        HourlyEmployeeDetails hourlyEmployeeDetails;
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employees = new Employees();
            if (!employees.Load(employeesFile))
            {
                MessageBox.Show("Unable to load employees file");
            }
            else
            {
                PopulateListBox();
            }


            
        }
        
        private void PopulateListBox()
        {
            listBoxEmployees.Items.Clear();
            employees.Sort();
            foreach (Employee employee in employees)
            {
                listBoxEmployees.Items.Add(employee.LastName + ", " + employee.FirstName);
            }
            listBoxEmployees.SelectedIndex = 0;
        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {

            if (employees[listBoxEmployees.SelectedIndex].GetType() == typeof(HourlyEmployee))
            {
                hourlyEmployeeDetails = new HourlyEmployeeDetails();
                hourlyEmployeeDetails.hourlyEmployeeDetails = (HourlyEmployee)employees[listBoxEmployees.SelectedIndex];
                if (hourlyEmployeeDetails.ShowDialog() == DialogResult.OK)
                {
                    if (employees[listBoxEmployees.SelectedIndex].Equals(hourlyEmployeeDetails.hourlyEmployeeDetails))
                    {
                        //What can be inserted in case they are equal?
                    }
                    else
                    {
                        employees[listBoxEmployees.SelectedIndex] = hourlyEmployeeDetails.hourlyEmployeeDetails;
                        employees.Save("employees.txt");
                        PopulateListBox();
                    }

                }
                
            }
            else if (employees[listBoxEmployees.SelectedIndex].GetType() == typeof(SalariedEmployee))
            {
                salariedEmployeeDetails = new SalariedEmployeeDetails();
                salariedEmployeeDetails.salariedEmployeeDetails = (SalariedEmployee)employees[listBoxEmployees.SelectedIndex];
                if (salariedEmployeeDetails.ShowDialog() == DialogResult.OK)
                {
                    if (employees[listBoxEmployees.SelectedIndex].Equals(salariedEmployeeDetails.salariedEmployeeDetails))
                    {
                        //What can be inserted in case they are equal?
                    }
                    else
                    {
                        employees[listBoxEmployees.SelectedIndex] = salariedEmployeeDetails.salariedEmployeeDetails;
                        employees.Save("employees.txt");
                        PopulateListBox();
                    }
                }
                

            }
        }

        private void buttonNewSalaried_Click(object sender, EventArgs e)
        {
            salariedEmployeeDetails = new SalariedEmployeeDetails();
            SalariedEmployee salariedEmployee = new SalariedEmployee();
            salariedEmployee.DateOfBirth = new DateTime(1753,1,1);
            salariedEmployeeDetails.salariedEmployeeDetails = salariedEmployee;

            if (salariedEmployeeDetails.ShowDialog() == DialogResult.OK)
            {
                salariedEmployee = salariedEmployeeDetails.salariedEmployeeDetails;
                employees.Add(salariedEmployee);
                employees.Save("employees.txt");
                PopulateListBox();
            }
            
        }

        private void buttonNewHourly_Click(object sender, EventArgs e)
        {
            hourlyEmployeeDetails  = new HourlyEmployeeDetails();
            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.DateOfBirth = new DateTime(1753,1,1);

            hourlyEmployeeDetails.hourlyEmployeeDetails = hourlyEmployee;
            
            if (hourlyEmployeeDetails.ShowDialog() == DialogResult.OK)
            {
                hourlyEmployee = hourlyEmployeeDetails.hourlyEmployeeDetails;
                employees.Add(hourlyEmployee);
                employees.Save("employees.txt");
                PopulateListBox();
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (employees[listBoxEmployees.SelectedIndex].GetType() == typeof(HourlyEmployee))
            {
                hourlyEmployeeDetails = new HourlyEmployeeDetails();
                hourlyEmployeeDetails.hourlyEmployeeDetails = (HourlyEmployee)employees[listBoxEmployees.SelectedIndex];
                if (hourlyEmployeeDetails.ShowDialog() == DialogResult.OK)
                {
                    if (employees[listBoxEmployees.SelectedIndex].Equals(hourlyEmployeeDetails.hourlyEmployeeDetails))
                    {
                        //What can be inserted in case they are equal?
                    }
                    else
                    {
                        employees[listBoxEmployees.SelectedIndex] = hourlyEmployeeDetails.hourlyEmployeeDetails;
                        employees.Save("employees.txt");
                        PopulateListBox();
                    }
                    
                }
                
            }
            else if (employees[listBoxEmployees.SelectedIndex].GetType() == typeof(SalariedEmployee))
            {
                salariedEmployeeDetails = new SalariedEmployeeDetails();
                salariedEmployeeDetails.salariedEmployeeDetails = (SalariedEmployee)employees[listBoxEmployees.SelectedIndex];
                if (salariedEmployeeDetails.ShowDialog() == DialogResult.OK)
                {
                    if (employees[listBoxEmployees.SelectedIndex].Equals(salariedEmployeeDetails.salariedEmployeeDetails) == false)
                    {
                        //What can be inserted in case they are equal?
                    }
                    else
                    {
                        employees[listBoxEmployees.SelectedIndex] = salariedEmployeeDetails.salariedEmployeeDetails;
                        employees.Save("employees.txt");
                        PopulateListBox();
                    }
                }
                
                
            }
        }
    }
}