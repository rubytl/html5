using System;
using System.Collections.Generic;
using System.Text;
using MSMEnumerations;

namespace MSMHelpers
{
    public class FilterTypeHelper
    {
        public static List<int?> GetFilterTypeCode(int filterType)
        {
            List<int?> res = new List<int?>();
            switch (filterType)
            {
                case (int)FilterTypeEnum.all:
                    res = new List<int?>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                    break;
                case (int)FilterTypeEnum.hasAlarm:
                    res = new List<int?>() { 2, 3, 7, 8, 9, 10, 11 };
                    break;
                default:
                    res = new List<int?> { filterType };
                    break;
            }

            return res;
        }
    }
}
