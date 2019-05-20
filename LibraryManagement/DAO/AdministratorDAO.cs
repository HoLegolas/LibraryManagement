using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class AdministratorDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from banquanli";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }
    }
}
