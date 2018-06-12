using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class MSMDictionaryController : Controller
    {
        private readonly IMSMDictionaryRepository dictionaryRepository;

        public MSMDictionaryController(IMSMDictionaryRepository dictionaryRepository)
        {
            this.dictionaryRepository = dictionaryRepository;
        }

        [HttpGet("byid/{itemId}")]
        public IActionResult GetMsmDictionaryById(string itemId)
            => Ok(this.MapEntityToDictionaryModel(this.dictionaryRepository.GetMsmDictionaryById(itemId)));

        public async Task<IActionResult> GetMsmDictionary()
           => Ok(this.MapEntityToDictionaryModel(await this.dictionaryRepository.GetAll()));

        private List<MSMDictionaryModel> MapEntityToDictionaryModel(IEnumerable<Msmdictionary> dictionaries)
        {
            List<MSMDictionaryModel> result = new List<MSMDictionaryModel>();
            foreach (var dictionary in dictionaries)
            {
                result.Add(MSMDictionaryMapping.MapEntityToDictionaryModel(dictionary));
            }

            return result;
        }
    }
}