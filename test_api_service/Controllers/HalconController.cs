using Microsoft.AspNetCore.Mvc;
using HalconDotNet;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_api_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HalconController : ControllerBase
    {
  

        // GET: api/<HalconController>
        [HttpGet]
        public ActionResult Get()
        {
            xxx.xxxx += $"{DateTime.Now} Request {Environment.NewLine}";
            try
            {
                HOperatorSet.GetSystem("hostids", out HTuple res);
                string[] data = new string[res.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = res[i].S;
                }
                xxx.xxxx += $"{DateTime.Now} OK {Environment.NewLine}";
                return Ok(data);
            }
            catch(Exception ex)
            {
                xxx.xxxx += $"{DateTime.Now} Fail {ex.Message} {Environment.NewLine}";
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("error")]
        public ActionResult Get2()
        {
            return Ok(xxx.xxxx);
        }
    }

}
