using System;
using System.Collections.Generic;
using System.Text;

namespace HRApplication
{
    public class HourlyEmployee : Employee
    {
        decimal _HourlyPay;
        decimal _OvertimePay;
        public HourlyEmployee()
        {
            
        }

        public HourlyEmployee(string firstName,
                              string lastName,
                              string address,
                              string postCode,
                              string phoneNumber,
                              DateTime dateOfBirth,
                              decimal hourlyPay,
                              decimal overtimePay) : base(firstName, lastName, address, postCode, phoneNumber, dateOfBirth)

        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostCode = postCode;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            _HourlyPay = hourlyPay;
            _OvertimePay = overtimePay;
        }


        public decimal HourlyPay
        {
            get { return _HourlyPay; }
            set { _HourlyPay = value; }
        }

        public decimal OvertimePay
        {
            get { return _OvertimePay; }
            set { _OvertimePay = value; }
        }

        public override string dataSave()
        {
            return "H|" + LastName + "|" + 
                FirstName + "|" + Address + 
                "|" + PostCode + "|" + PhoneNumber +
                "|" +
                DateOfBirth.Year.ToString() + 
                "|" + DateOfBirth.Month.ToString() +
                "|" + DateOfBirth.Day.ToString()
                + "|" + HourlyPay.ToString() +
                "|" + OvertimePay.ToString();
        }

    }
}
