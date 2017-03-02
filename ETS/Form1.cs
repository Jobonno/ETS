using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS.Entity;
using ETS.Manager;

namespace ETS
{
    public partial class Form1 : Form
    {
        //lists for two entity types
        List<Employee> lst;
        List<Timesheet> timelist;
        public Form1()
        {


            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            DateTime dob = dtpDOB.Value;
            string phone = txtPhone.Text;
            
            //checks whether all details are valid

            if (firstName==""||lastName==""||email==""||phone=="")
            {
                MessageBox.Show("Please fill out all details!");
            }else
            {
                Employee emp = new Employee(firstName, lastName, email, dob, phone);
                EmployeeManager manager = new EmployeeManager();

                ResultEnum result = manager.AddEmployee(emp);
                switch (result)
                {
                    case ResultEnum.SUCCESS:
                        MessageBox.Show("New Employee Added");
                        break;
                    case ResultEnum.FAIL:
                        MessageBox.Show("Error, Something went wrong");
                        break;

                }

                //updates the list to show current items

                lstBoxEmployeesReport.Items.Clear();
                lstboxEmployees.Items.Clear();

                Result<List<Employee>> result1 = manager.CreateList();
                lst = result1.List;
                switch (result1.Status)
                {
                    case ResultEnum.SUCCESS:
                        foreach (Employee obj in lst)
                        {
                            lstboxEmployees.Items.Add(obj);
                            lstBoxEmployeesReport.Items.Add(obj);
                        }
                        break;
                    case ResultEnum.FAIL:
                        MessageBox.Show("Error, Something went wrong");
                        break;
                }

            }

            


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            dtpDOB.ResetText();
            txtPhone.Clear();

        }



        //update employee details and refreshes the lists

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            EmployeeManager manager = new EmployeeManager();
            Employee emp = new Employee();
            try
            {
                emp.EmpId = int.Parse(lblID.Text);
                emp.FirstName = txtFirstName2.Text;
                emp.LastName = txtLastName2.Text;
                emp.Email = txtEmail2.Text;
                emp.Dob = dtpDOB2.Value;
                emp.Phone = txtPhone2.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select an Employee!");

            } 
            
            ResultEnum result = manager.Update(emp);
            switch (result)
            {
                case ResultEnum.SUCCESS:
                    MessageBox.Show("Update Successful");
                    break;
                case ResultEnum.FAIL:
                    MessageBox.Show("Error, Something went wrong");
                    break;

            }
            lstBoxEmployeesReport.Items.Clear();
            lstboxEmployees.Items.Clear();
            
            Result<List<Employee>> result1 = manager.CreateList();
            lst = result1.List;
            switch (result1.Status)
            {
                case ResultEnum.SUCCESS:
                    foreach (Employee obj in lst)
                    {
                        lstboxEmployees.Items.Add(obj);
                        lstBoxEmployeesReport.Items.Add(obj);
                    }
                    break;
                case ResultEnum.FAIL:
                    MessageBox.Show("Error, Something went wrong");
                    break;
            }



        }

        private void btnAddTimesheet_Click(object sender, EventArgs e)
        {
            if (lst != null && lstboxEmployees.SelectedItem != null)
            {
                foreach (Employee obj in lst)
                {
                    if (obj == lstboxEmployees.SelectedItem)
                    {
                        try
                        {
                            int empid = obj.EmpId;
                            DateTime dateWorked = dtpWorkedDate.Value;
                            double hours = double.Parse(txtHours.Text);
                            Timesheet tim = new Timesheet();
                            tim.EmpId = empid;
                            tim.WorkDate = dateWorked;
                            tim.Hours = hours;
                            
                            TimesheetManager manager = new TimesheetManager();
                            ResultEnum result = manager.AddTimesheet(tim);
                            switch (result)
                            {
                                case ResultEnum.SUCCESS:
                                    MessageBox.Show("New TimeSheet Added");
                                    break;
                                case ResultEnum.FAIL:
                                    MessageBox.Show("Error, Something went wrong");
                                    break;

                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Please Enter Hours");
                        }


                    }
                }

            }
            else MessageBox.Show("Please Select an employee!");

        }

        private void lstboxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Employee obj in lst)
            {
                if (obj == lstboxEmployees.SelectedItem)
                {
                    lblID.Text = obj.EmpId.ToString();
                    txtFirstName2.Text = obj.FirstName;
                    txtLastName2.Text = obj.LastName;
                    txtEmail2.Text = obj.Email;
                    dtpDOB2.Value = obj.Dob;
                    txtPhone2.Text = obj.Phone;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //displays names in manage tab &
            //displays names in reports tab
            EmployeeManager manager = new EmployeeManager();
            Result<List<Employee>> result = manager.CreateList();
            lst = result.List;
            switch (result.Status)
            {
                case ResultEnum.SUCCESS:
                    foreach (Employee obj in lst)
                    {
                        lstboxEmployees.Items.Add(obj);
                        lstBoxEmployeesReport.Items.Add(obj);
                    }
                    break;
                case ResultEnum.FAIL:
                    MessageBox.Show("Error, Something went wrong");
                    break;
            }
           

        }

        private void lstBoxEmployeesReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstboxReport.Items.Clear();
            foreach (Employee obj in lst)
            {
                if (obj == lstBoxEmployeesReport.SelectedItem)
                {
                    int EmpId = obj.EmpId;
                    TimesheetManager manager = new TimesheetManager();
                    Result<List<Timesheet>> result = manager.DisplayReport(EmpId);
                    timelist  = result.List;
                    switch (result.Status)
                    {
                        case ResultEnum.SUCCESS:
                            foreach (Timesheet tim in timelist)
                            {

                                lstboxReport.Items.Add(tim);
                            }
                            break;
                        case ResultEnum.FAIL:
                            MessageBox.Show("Error, Something went wrong");
                            break;
                      
                    }
                    
                    
                }
            }
        }

        private void btnTotalHours_Click(object sender, EventArgs e)
        {
            if (lst != null)
            {
                foreach (Employee obj in lst)
                {
                    if (obj == lstBoxEmployeesReport.SelectedItem)
                    {
                        int empId = obj.EmpId;
                        TimesheetManager manager = new TimesheetManager();
                        double sum = manager.SumOfHours(empId);
                        MessageBox.Show("Total hours worked " + sum + " hours");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
