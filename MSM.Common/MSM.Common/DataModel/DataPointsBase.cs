namespace DataModel.DataPoints
{
    using DataModel.DataPoints;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;

    public class DataPointsBase
    {
        private static DataPointsBase instance;
        protected static List<DataPointsBase> dataPoints;
        public List<DataPointDef> Items { get; set; }
        public DataModelType Identifier { get; set; }
        protected static object objLock = new object();

        public static DataPointsBase Instance()
        {
            if (instance == null)
            {
                instance = new DataPointsBase();
            }

            return instance;
        }

        private DataPointsBase()
        {
            if (dataPoints == null)
            {
                dataPoints = new List<DataPointsBase>();
                DataPointsBase delta = new DataPointsBase(DataModelType.DeltaData);
                DataPointsBase eltek = new DataPointsBase(DataModelType.EltekData);
                dataPoints.Add(eltek);
                dataPoints.Add(delta);

                if (Items == null)
                {
                    Items = new List<DataPointDef>();
                }

                Items.AddRange(eltek.Items);
                Items.AddRange(delta.Items);
            }
        }

        public static DataPointsBase Instance(DataModelType identifier)
        {
            if (dataPoints == null)
            {
                dataPoints = new List<DataPointsBase>();
            }

            var dataPointList = dataPoints.Where(s => s.Identifier == identifier).FirstOrDefault();

            if (dataPointList == null)
            {
                dataPoints.Add(new DataPointsBase(identifier));
                return dataPoints[dataPoints.Count - 1];
            }

            return dataPointList;
        }

        public static DataPointsBase Instance(int controllerType)
        {
            DataModelType identifier = DataModelType.EltekData;
            if (controllerType == 2)
            {
                identifier = DataModelType.DeltaData;
            }

            return Instance(identifier);
        }

        public DataPointsBase(DataModelType identifier)
        {
            Identifier = identifier;

            IDataPoint dataModelType;

            switch (identifier)
            {
                default:
                case DataModelType.EltekData:
                    dataModelType = new EltekDataPoints();
                    break;
                case DataModelType.DeltaData:
                    dataModelType = new DeltaDataPoints();
                    break;
            }

            Items = dataModelType.Items;
        }

        public DataPointDef GetItem(string dataPath)
        {
            foreach (var item in Items)
            {
                if (item.DataPath.ToLower() == dataPath.ToLower())
                {
                    return item;
                }
            }

            return null;
        }

        public DataPointDef GetItem(ProtocolDef protocolId)
        {

            foreach (var item in Items)
            {
                if (item.ProtocolId == protocolId)
                {
                    return item;
                }
            }

            return null;
        }

    }


    public class DataPointDef
    {
        public DataPointDef()
        {

        }

        ///// <summary>
        ///// Id number
        ///// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// Protocol def enum value
        /// </summary>
        [DefaultValue(ProtocolDef.NoDef)]
        public ProtocolDef ProtocolId { get; set; }

        /// <summary>
        /// Data point. Different for different controllers
        /// </summary>
        public string DataPath { get; set; }

        [DefaultValue("")]
        public string DataType { get; set; }
    }

    public class PathAndType
    {
        #region Constructors

        public PathAndType()
        {
        }

        public PathAndType(string path, string type)
        {
            Path = path;
            Type = type;
        }

        #endregion Constructors

        #region Properties

        public string Path
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        #endregion Properties


        public static ProtocolDef GetProtocolDef(ref PathAndType item, DataModelType identifier)
        {
            var dataPointItem = DataPointsBase.Instance(identifier).GetItem(item.Path);
            if (dataPointItem == null)
                return 0;
            if (item.Type == "")
            {
                item.Type = dataPointItem.DataType;
            }
            return dataPointItem.ProtocolId;
        }

        public static ProtocolDef GetProtocolId(ref PathAndType item, DataModelType identifier)
        {
            var dataPointItem = DataPointsBase.Instance(identifier).GetItem(item.Path);
            if (dataPointItem == null)
                return 0;
            if (item.Type == "")
            {
                item.Type = dataPointItem.DataType;
            }
            return dataPointItem.ProtocolId;
        }

        public static ProtocolDef GetProtocolId(PathAndType item)
        {
            return GetProtocolId(ref item, DataModelType.EltekData);
        }

        public static string GetDataPoint(ProtocolDef protocolId, DataModelType identifier)
        {
            var dataPointItem = DataPointsBase.Instance(identifier).GetItem(protocolId);
            if (dataPointItem == null)
                return string.Empty;
            return dataPointItem.DataPath;

        }

        public static DataPointDef GetDataItem(ProtocolDef protocolId, DataModelType identifier)
        {
            var dataPointItem = DataPointsBase.Instance(identifier).GetItem(protocolId);
            if (dataPointItem == null)
                return null;
            return dataPointItem;

        }


    }

    public class PathAndValueModel
    {
        #region Constructors

        public PathAndValueModel()
        {
        }

        public PathAndValueModel(object path, string value)
        {
            Path = path;
            Value = value;
        }

        #endregion Constructors

        #region Properties

        public object Path
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public string MessageContent
        {
            get;
            set;
        }

        #endregion Properties
    }

    public class MessageCollection
    {
        #region Constructor

        public MessageCollection()
        {
            PathAndValue = new List<PathAndValueModel>();
        }

        #endregion

        #region Properties

        public List<PathAndValueModel> PathAndValue
        {
            get;
            set;
        }

        public string MessagePrefix
        {
            get;
            set;
        }

        #endregion
    }

}
