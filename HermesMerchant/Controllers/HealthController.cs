using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HermesMerchant.Controllers
{
    /// <summary>
    /// 健康查询控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        #region Action
        [HttpGet("check")]
        public IActionResult Get()
        {
            return Content("ok");
        }
        #endregion //Action
    }
}
