using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HRApplication
{
    public class Employees : List<Employee>
    {
        public Employees()
        {
        }
        
        public bool Load(string filename)
        {
            StreamReader reader = null;
            string readLine;
            string[] employeeDetails;
            

            if (File.Exists(filename) == false)
            {
                return false;
            }

            try
                {
               reader = new StreamReader(filename);
                if (reader != null)
                {
                    readLine = reader.ReadLine();
                    while (readLine != "")
                    {

                        if (readLine[0] == 'S')
                        {
                            employeeDetails = readLine.Split('|');
                            Employee newEmployee = new SalariedEmployee(employeeDetails[1], employeeDetails[2], employeeDetails[3], employeeDetails[4], employeeDetails[5], new DateTime(int.Parse(employeeDetails[6]), int.Parse(employeeDetails[7]), int.Parse(employeeDetails[8])), decimal.Parse(employeeDetails[9]));
                            Add(newEmployee);
                        }
                        else if (readLine[0] == 'H')
                        {
                            employeeDetails = readLine.Split('|');
                            Employee newEmployee = new HourlyEmployee(employeeDetails[1], employeeDetails[2], employeeDetails[3], employeeDetails[4], employeeDetails[5], new DateTime(int.Parse(employeeDetails[6]), int.Parse(employeeDetails[7]), int.Parse(employeeDetails[8])), decimal.Parse(employeeDetails[9]), decimal.Parse(employeeDetails[10]));
                            Add(newEmployee);
                        }
                        readLine = reader.ReadLine();
                        if (readLine == null)
                        break;
                        
                    }
                }
                               
                reader.Close();
                return true;
                
            }

            catch
            {
                return false;
            }
          
                 
                
        }
        
        public bool Save(string filename)
        {
            
            
            StreamWriter textOut = new StreamWriter(filename, false);
            string lineReader;
            try
            {
                if (textOut != null)
                
                    foreach (Employee employee in this)
                    {
                        lineReader = employee.dataSave();
                        textOut.WriteLine(lineReader);
                    }
                    textOut.Close();
                    return true;
                
            }
            catch
            {
                return false;
            }
            
        }
    }
}
