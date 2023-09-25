using DataAccess;
using DataAccess.Interface;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class QuangCaoResponsitory : IQuangCaoReponsitory
    {
        public IDatabaseHelper _dbHelper;

        public QuangCaoResponsitory(DatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<QuangcaoModel> GetallQuangCao()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_quangcao");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<QuangcaoModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}