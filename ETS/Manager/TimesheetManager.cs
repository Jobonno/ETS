using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETS.DataAccess;
using ETS.Entity;

namespace ETS.Manager
{
    public class TimesheetManager
    {
        private readonly TimesheetDao dao;
        public TimesheetManager()
        {
            dao = new TimesheetDao();
        }
        public ResultEnum AddTimesheet(Timesheet tim)
        {
            try
            {
                dao.CreateTimesheet(tim);
                return ResultEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return ResultEnum.FAIL;
            }


        }
        //returns a result object which gives access to the created generic list and status  
        public Result<List<Timesheet>> DisplayReport(int empId)
        {
            Result<List<Timesheet>> res = new Result<List<Timesheet>>();
            try
            {
                res.List = dao.Report(empId);
                res.Status = ResultEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                res.Status = ResultEnum.FAIL;
            }
            return res;
        }
        
        public double SumOfHours(int empId)
        {
            Result<List<Timesheet>> res = new Result<List<Timesheet>>();
            try
            {
                return dao.SumOfHours(empId);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return 0;
            }
            

        }
    }
}
