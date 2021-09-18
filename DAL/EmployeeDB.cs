using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Lab1_ASPNetConnectedMode.BLL;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public static class EmployeeDB
    {
        // <summary>
        // This method saves an Employee object to the database; Version 1
        // </summary>
        // <param name = "emp" ></ param >
        //public static void SaveRecord(Employee emp)
        //{
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = connDB;
        //    cmd.CommandText = "INSERT INTO Employees " +
        //    "VALUES (" + emp.EmployeeId + ",'" +
        //    emp.FirstName + "','" +
        //    emp.LastName + "','" +
        //    emp.JobTitle + "')";
        //    cmd.ExecuteNonQuery();
        //    connDB.Close();
        //}

        public static void SaveRecord(Employee emp)
        {
            //Step1 : Connect the database
            SqlConnection conn = UtilityDB.ConnectDB();

            //Step 2: Perform the INSERT(Save operation)
            try
            {
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = conn;
                cmdInsert.CommandText = "INSERT INTO Employees(EmployeeId,FirstName,LastName,JobTitle) " +
                                        "VALUES(@EmployeeId,@FirstName,@LastName,@JobTitle)";
                cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
                cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
                cmdInsert.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Step 3 : Close the DB connection
                conn.Close();

            }

        }

        public static List<Employee> GetRecordList()
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp; //object declaration

            while (sqlReader.Read())
            {
                emp = new Employee();//object creation
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }

            conn.Close();
            return listEmp;

        }

        public static Employee SearchRecordById(int Id)
        {
            Employee emp = new Employee();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " + "WHERE EmployeeId = @EmployeeId";
            cmdSelect.Parameters.AddWithValue("@EmployeeID", Id);
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["employeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                return emp;
            }
            

            return null;
        }

        public static List<Employee> SearchRecord(string name)
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " + "WHERE FirstName = @FirstName" + " Or LastName = @LastName";
            cmdSelect.Parameters.AddWithValue("@FirstName", name);
            cmdSelect.Parameters.AddWithValue("@LastName", name);
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;

            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["employeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }

            return listEmp;
        }

        public static List<Employee> SearchRecordByJobs(string job)
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " + "WHERE JobTitle = @Jobtitle";
            cmdSelect.Parameters.AddWithValue("@JobTitle", job);
            
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;

            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["employeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }

            return listEmp;
        }

        public static void UpdateEmployee(Employee emp)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees SET EmployeeId = @EmployeeId, FirstName = @FirstName, LastName = @LastName, JobTitle = @JobTitle WHERE EmployeeId = @EmployeeID";
            cmdUpdate.Parameters.AddWithValue("@EmployeeID", emp.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

            cmdUpdate.Connection = conn;
            cmdUpdate.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteRecord(int empId)
        {

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();

            cmdDelete.CommandText = "DELETE From Employees WHERE EmployeeId = @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);

            cmdDelete.Connection = conn;
            cmdDelete.ExecuteNonQuery();
            conn.Close();

        }

        public static List<Employee> GetRecordList(int Id)
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT " + Id + " FROM Employees", conn);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;

            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }

            conn.Close();
            return listEmp;

        }

    }
}