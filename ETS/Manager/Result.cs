using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETS.Entity;



namespace ETS.Manager
{
    public class Result<T>
    {
        private ResultEnum status;
        private T list;  
        public T List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        public ResultEnum Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
