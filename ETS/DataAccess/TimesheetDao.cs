using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ETS.Entity;

namespace ETS.DataAccess
{
    public class TimesheetDao
    {
        public void CreateTimesheet(Timesheet tim)
        {
            //access to the EmpHours table
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_Insert_EmpHours", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empId", tim.EmpId));
                comm.Parameters.Add(new SqlParameter("@workDate", tim.WorkDate));
                comm.Parameters.Add(new SqlParameter("@hours", tim.Hours));
                
                comm.ExecuteNonQuery();
            }
       }
        public List<Timesheet> Report(int empId)
        {
            //returns a list of timesheets based on current EmpId table
            List<Timesheet> lst = new List<Timesheet>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_Select_EmpID_Show_Hours", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empId", empId));
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Timesheet tim = new Timesheet();
                    tim.EmpId = empId;
                    tim.WorkDate = Convert.ToDateTime(reader.GetDateTime(2));
                    tim.Hours = Convert.ToDouble(reader.GetDecimal(3));
                   
                    lst.Add(tim);
                }
                return lst;
            }

        }
        public double SumOfHours(int empId)
        {
            //returns the sum of total hours based on employeeId
            double result = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnectionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_Sum_of_Hours", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empId", empId));
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToDouble(reader.GetDecimal(0));
                    
                }
                return result;


            }
        }

    }
}
