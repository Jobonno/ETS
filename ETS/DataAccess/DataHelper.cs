using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.DataAccess
{
    
        public static class DataHelper
        {
            public static string GetConnectionString()
            {
            //Connection string storage for home and tafe

            //return @"Data Source=JOESPC\SQLEXPRESS;Initial Catalog=JosephProject;Integrated Security=True";
            return "Data Source=PEA106-09;Initial Catalog=JosephProject;User ID=sa;Password=Petersham";
            }
    }
    
}
