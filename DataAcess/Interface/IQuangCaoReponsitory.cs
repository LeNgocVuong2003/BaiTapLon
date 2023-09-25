using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Interface
{
    public partial interface IQuangCaoReponsitory
    {
        List<QuangcaoModel> GetallQuangCao();
    }
}
