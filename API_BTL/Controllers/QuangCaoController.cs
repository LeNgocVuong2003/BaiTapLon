using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuangCaoController : ControllerBase
    {

        private IQuangCaoBUSS _quangCaoBuss;
        public QuangCaoController(IQuangCaoBUSS quangCao)
        {
            _quangCaoBuss = quangCao;
        }
        [Route("get-all-quangcao")]
        [HttpGet]
        public IEnumerable< QuangcaoModel> GetQuangcaoModel() 
        {
            return _quangCaoBuss.GetallQuangCao();
        }

    }
}
