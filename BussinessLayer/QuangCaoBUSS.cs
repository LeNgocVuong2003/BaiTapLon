using BussinessLayer.Interface;
using DataAccess;
using DataAccess.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public partial class QuangCaoBUSS : IQuangCaoBUSS
    {
        public IQuangCaoReponsitory _res;
        public QuangCaoBUSS( IQuangCaoReponsitory quangCaoResponsitory)
        {
            _res = quangCaoResponsitory;
        }
        public List<QuangcaoModel> GetallQuangCao()
        {
            return _res.GetallQuangCao();
        }
    }
}
