using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    public static class MSMDictionaryMapping
    {
        public static MSMDictionaryModel MapEntityToDictionaryModel(Msmdictionary entity)
        {
            return new MSMDictionaryModel()
            {
                Description = entity.Description,
                ExtVal = entity.ExtVal,
                ItemId = entity.ItemId,
                ItemName = entity.ItemName
            };
        }
    }
}
