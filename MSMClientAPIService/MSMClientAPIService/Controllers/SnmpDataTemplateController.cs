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
    [Route("api/snmpdata")]
    public class SnmpDataTemplateController : Controller
    {
        private readonly ISnmpDataTemplateRepository snmpDataRepo;
        public SnmpDataTemplateController(ISnmpDataTemplateRepository snmpDataRepo)
        {
            this.snmpDataRepo = snmpDataRepo;
        }

        // GET: api/Template
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.snmpDataRepo.GetAll());
    }
}