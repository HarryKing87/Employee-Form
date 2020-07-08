using System;
using System.Collections.Generic;
using System.Text;

namespace HRApplication
{
    public class SalariedEmployee : Employee
    {
        decimal _Salary;
        //Constructors
        public SalariedEmployee()
        {
        }
        
        public SalariedEmployee(string firstName,
                                string lastName,
                                string address,
                                string postCode,
                                string phoneNumber,
                                DateTime dateOfBirth,
                                decimal salary) : base(firstName, lastName, address, postCode, phoneNumber, dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostCode = postCode;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            _Salary = salary;
        }

        //Get Set
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        //The method that writes the saved employee details with a specified way.
        public override string dataSave()
        {
            return "S|" + LastName +
                "|" + FirstName +
                "|" + Address 
                + "|" + PostCode 
                + "|" + PhoneNumber 
                + "|"
                + DateOfBirth.Year.ToString() 
                + "|" +
                DateOfBirth.Month.ToString() 
                + "|" + DateOfBirth.Day.ToString() 
                + "|" + Salary.ToString();
        }

        
        


    }
}
