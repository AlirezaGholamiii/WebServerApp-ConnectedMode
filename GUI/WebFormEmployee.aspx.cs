using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1_ASPNetConnectedMode.BLL;
using Lab1_ASPNetConnectedMode.VALIDATION;
using System.Windows.Forms;

namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebFormEmployee : System.Web.UI.Page
    {

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee tempEmp = new Employee();

            string tempId = txtEmployeeId.Text.Trim();
            if (!(Validator.IsValidId(tempId, 4)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;
            }

            tempEmp.SearchEmployee(tempId);

            string tempFirstName = txtFirstName.Text.Trim();
            if (!(Validator.IsValidName(tempFirstName)))
            {
                MessageBox.Show("Invalid First Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Text = "";
                txtFirstName.Focus();
                return;
            }

            string tempLastName = txtLastName.Text.Trim();
            if (!(Validator.IsValidName(tempLastName)))
            {
                MessageBox.Show("Invalid Last Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJobTitle.Text = "";
                txtJobTitle.Focus();
                return;
            }

            string tempJob = txtJobTitle.Text.Trim();
            if ((Validator.IsEmpty(tempJob)))
            {
                MessageBox.Show("Job Title is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Text = "";
                txtLastName.Focus();
                return;
            }

            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtEmployeeId.Text.Trim());
            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtLastName.Text.Trim();
            emp.JobTitle = txtJobTitle.Text.Trim();

            MessageBox.Show("Employee data successfully Updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tempEmp.UpdateRecord(emp);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string tempId = txtEmployeeId.Text.Trim();
            if (!(Validator.IsValidId(tempId, 4)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;
            }

            Employee tempEmp = new Employee();
            tempEmp = tempEmp.SearchEmployee(Convert.ToInt32(tempId));
            if (tempEmp != null)
            {
                MessageBox.Show("This Employee ID already exist.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;
            }

            string tempFirstName = txtFirstName.Text.Trim();
            if (!(Validator.IsValidName(tempFirstName)))
            {
                MessageBox.Show("Invalid first name or is empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Text = "";
                txtFirstName.Focus();
                return;
            }

            string tempLastName = txtLastName.Text.Trim();
            if (!(Validator.IsValidName(tempLastName)))
            {
                MessageBox.Show("Invalid last name or is empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Text = "";
                txtLastName.Focus();
                return;
            }

            string tempJob = txtJobTitle.Text.Trim();
            if ((Validator.IsEmpty(tempJob)))
            {
                MessageBox.Show("Job title box can't be empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJobTitle.Text = "";
                txtJobTitle.Focus();
                return;
            }

            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtEmployeeId.Text.Trim());
            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtJobTitle.Text.Trim();
            emp.JobTitle = txtLastName.Text.Trim();


            emp.SaveEmployee(emp);
            MessageBox.Show("Employee data saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string tempId = txtEmployeeId.Text.Trim();
            if (!(Validator.IsValidId(tempId, 4)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;
            }

            Employee tempEmp = new Employee();
            tempEmp = tempEmp.SearchEmployee(Convert.ToInt32(tempId));
            if (tempEmp == null)
            {
                MessageBox.Show("This Employee ID does not exist", "No Employee ID Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;
            }
            else
            {
                DialogResult delete = MessageBox.Show("Are You Sure You Want To Delete This Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    tempEmp.DeleteEmployee(Convert.ToInt32(tempId));
                }

            }
        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = new List<Employee>();
            listEmp = emp.ListEmployees();
            GridViewEmployee.DataSource = listEmp;
            GridViewEmployee.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Employee emp; 
            List<Employee> listEmp;
            string tempInfo = TxtSearchBy.Text.Trim();
            
            if (Validator.IsEmpty(tempInfo))
            {
                MessageBox.Show("The search field can not be empty.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSearchBy.Focus();
                return;
            }
            
            int index = DropDownListSearchOptions.SelectedIndex;
            
            switch (index)
            {
                case 0:

                    if (Validator.IsValidId(tempInfo, 4))
                    {
                        emp = new Employee();
                        listEmp = new List<Employee>();
                    
                        emp = emp.SearchEmployee(Convert.ToInt32(TxtSearchBy.Text.Trim()));
                        listEmp.Add(emp);

                        if (emp != null)
                        {
                            GridViewEmployee.DataSource = listEmp;
                            GridViewEmployee.DataBind();

                        }
                        else
                        {
                            MessageBox.Show("Employee ID not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valide ID that contains 4 digits.");
                    }
                    
                    break;
                case 1:
                    if (Validator.IsValidName(tempInfo))
                    {
                        emp = new Employee();
                        listEmp = emp.SearchEmployee(tempInfo);

                        if (listEmp != null)
                        {
                            GridViewEmployee.DataSource = listEmp;
                            GridViewEmployee.DataBind();

                        }
                        else
                        {
                            MessageBox.Show("Employee with this first name was not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("First or last name can not contain a digit or space.");
                    }
                    break;
                case 2:
                    if (Validator.IsAWord(tempInfo))
                    {
                        emp = new Employee();
                        listEmp = emp.SearchEmployeeByJob(tempInfo);

                        if (listEmp != null)
                        {
                            GridViewEmployee.DataSource = listEmp;
                            GridViewEmployee.DataBind();

                        }
                        else
                        {
                            MessageBox.Show("Employee(s) with this job title was not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valide job title and it can not contain digits or special characters.");
                    }
                    break;
                default:
                    MessageBox.Show("Select an option.");
                    break;


            }
                
                
        }
    }
}