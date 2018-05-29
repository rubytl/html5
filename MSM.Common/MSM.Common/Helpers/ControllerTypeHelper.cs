using System;
using System.Collections.Generic;
using System.Text;
using MSMEnumerations;

namespace MSM.Common.Helpers
{
    public static class ControllerTypeHelper
    {
        public static bool ShouldDefineSecurityProtocol(ControllerTypeEnum type)
        {
            switch (type)
            {
                case ControllerTypeEnum.COMPACK:
                case ControllerTypeEnum.MCF5235:
                case ControllerTypeEnum.MCF5208:
                case ControllerTypeEnum.SMARTPACK2:
                case ControllerTypeEnum.SMARTPACKS:
                case ControllerTypeEnum.SMARTPACK:
                    return true;
                case ControllerTypeEnum.ORION:
                default:
                    return false;
            }
        }
    }
}
