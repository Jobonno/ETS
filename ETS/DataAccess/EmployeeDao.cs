using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ETS.Entity;


namespace ETS.DataAccess
{
   public class EmployeeDao
    {
        public void CreateEmployee(Employee emp)
        {
            //accessing stored procedure insert_employee
            //creating connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                //accessing command
                SqlCommand comm = new SqlCommand("sp_Insert_Employee", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                //adding the parameters
                comm.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                comm.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                comm.Parameters.Add(new SqlParameter("@email", emp.Email));
                comm.Parameters.Add(new SqlParameter("@dob", emp.Dob));
                comm.Parameters.Add(new SqlParameter("@phone", emp.Phone));
                comm.ExecuteNonQuery();
            }
            
       
            
            
        }

        public List<Employee> PopulateList()
        {

            //returns a list of Employees using select_all_employees sp

            List<Employee> lst = new List<Employee>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_Select_All_Employees", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpId = reader.GetInt32(0);
                    emp.FirstName = reader.GetString(1);
                    emp.LastName = reader.GetString(2);
                    emp.Email = reader.GetString(3);
                    emp.Dob = reader.GetDateTime(4);
                    emp.Phone = reader.GetString(5);
                    lst.Add(emp);
                }
                return lst;
            }
            
        }
        public void UpdateEmployee(Employee emp)
        {
            //updates database based on user inputs
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_Update_Employee", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empId", emp.EmpId));
                comm.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                comm.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                comm.Parameters.Add(new SqlParameter("@email", emp.Email));
                comm.Parameters.Add(new SqlParameter("@dob", emp.Dob));
                comm.Parameters.Add(new SqlParameter("@phone", emp.Phone));
                comm.ExecuteNonQuery();
            }
                     

            
        }

    }
}
