using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/snmpconfig")]
    public class SnmpConfigTemplateController : Controller
    {
        private readonly ISnmpConfigTemplateRepository snmpConfigRepo;
        public SnmpConfigTemplateController(ISnmpConfigTemplateRepository snmpConfigRepo)
        {
            this.snmpConfigRepo = snmpConfigRepo;
        }

        // GET: api/Template
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.snmpConfigRepo.GetAll());
    }
}