using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Entity
{
    public class Timesheet
    {
        //fields
        private int empId;
        private DateTime workDate;
        private double hours;
        #region properties
        public DateTime WorkDate
        {
            get
            {
                return workDate;
            }

            set
            {
                workDate = value;
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public int EmpId
        {
            get
            {
                return empId;
            }

            set
            {
                empId = value;
            }
        }
        #endregion

        //methods
        public override string ToString()
        {
            return "On this Date :" + workDate.ToShortDateString() + " Worked : " + hours + " hours";
        }
    }
}
