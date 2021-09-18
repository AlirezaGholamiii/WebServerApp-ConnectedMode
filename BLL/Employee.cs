using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1_ASPNetConnectedMode.DAL;

namespace Lab1_ASPNetConnectedMode.BLL
{
    public class Employee
    {
        //private class variables
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;
        //properties
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        //custom methods

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public Employee SearchEmployee(int empId)
        {

            return EmployeeDB.SearchRecordById(empId);
        }

        public List<Employee> SearchEmployee(string name)
        {
            return EmployeeDB.SearchRecord(name);
        }

        public List<Employee> SearchEmployeeByJob(string empJobTitle)
        {
            return EmployeeDB.SearchRecordByJobs(empJobTitle);
        }
        public void DeleteEmployee(int empId)
        {
            EmployeeDB.DeleteRecord(empId);
        }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.GetRecordList();
        }

        public void UpdateRecord(Employee emp)
        {
            EmployeeDB.UpdateEmployee(emp);
        }
    }
}