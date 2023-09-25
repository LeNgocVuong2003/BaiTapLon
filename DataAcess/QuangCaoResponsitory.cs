using DataAccessLayer;
using DataAcess.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public partial class QuangCaoResponsitory : IQuangCaoReponsitory
    {
        public DatabaseHelper _databaseHelper;
        
        public QuangCaoResponsitory(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<QuangcaoModel> GetallQuangCao()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_quangcao";)
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<QuangCaomodel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
