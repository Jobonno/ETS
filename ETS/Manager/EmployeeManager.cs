using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETS.DataAccess;
using ETS.Entity;

namespace ETS.Manager
{
    public class EmployeeManager
    {
        private readonly EmployeeDao dao;
        public EmployeeManager()
        {
            dao = new EmployeeDao();
        }
        //returning a success or fail status
        public ResultEnum AddEmployee(Employee emp)
        {
            try
            {
                dao.CreateEmployee(emp);
                return ResultEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return ResultEnum.FAIL;
            }           
                       
            
        }
        //returns a result object which gives access to the created generic list and status  
        public Result<List<Employee>> CreateList()
        {
            Result<List<Employee>> res = new Result<List<Employee>>();
            try
            {
                res.List= dao.PopulateList();
                res.Status = ResultEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                res.Status = ResultEnum.FAIL;
            }
            return res;
            
        }
        public ResultEnum Update(Employee emp)
        {
            try
            {
                dao.UpdateEmployee(emp);
                return ResultEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return ResultEnum.FAIL;
            }
            
            
        }
    }
}
