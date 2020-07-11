using System;
using System.Collections.Generic;
using System.Text;

namespace HRApplication
{
    public class Employee : IComparable<Employee>
    {
        string _FirstName;
        string _LastName;
        string _Address;
        string _PostCode;
        string _PhoneNumber;
        DateTime _DateOfBirth;
        
        public Employee()
        {
        }
        
        public Employee(string firstName,
                        string lastName,
                        string address,
                        string postCode,
                        string phoneNumber,
                        DateTime dateOfBirth)

        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            PostCode = postCode;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName ; }
            set { _LastName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string PostCode
        {
            get { return _PostCode; }
            set { _PostCode = value; }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        
        public virtual string dataSave()
        {
            return "";
        }

        public int CompareTo(Employee anotherEmployee)
        {
            return LastName.CompareTo(anotherEmployee.LastName);
        }
    }
}
//Coding_Harry
