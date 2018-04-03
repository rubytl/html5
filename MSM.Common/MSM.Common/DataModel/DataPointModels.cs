using MSMEnumerations;
namespace DataModel.DataPoints
{
    #region Enumerations

    public enum DataModelType
    {
        EltekData,
        DeltaData,
    }

    #endregion Enumerations

    public static class DataPointModels
    {

        #region Methods

        public static DataModelType GetDataModel(ControllerTypeEnum controllerType)
        {
           switch (controllerType)
	        {
		        case ControllerTypeEnum.COMPACK:
                case ControllerTypeEnum.SMARTPACK2:
                case ControllerTypeEnum.SMARTPACKS:
                case ControllerTypeEnum.SMARTPACK:
                case ControllerTypeEnum.MCF5235:
                case ControllerTypeEnum.MCF5208:
                    return DataModelType.EltekData;
                case ControllerTypeEnum.ORION:
                    return DataModelType.DeltaData;
                default:
                    return DataModelType.EltekData;
           }
	    } 
     }
    #endregion

}
