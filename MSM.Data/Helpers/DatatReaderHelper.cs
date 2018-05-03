using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MSM.Data.Helpers
{
    public static class DatatReaderHelper
    {
        public static IList<T> MapToList<T>(this SqlDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetProperties();
            DataTable dt = new DataTable();
            dt.Load(dr);
            var colMapping = dt.Columns.Cast<DataColumn>()
              .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
              .ToDictionary(key => key.ColumnName.ToLower());

            if (dt.Rows.Count > 0)
            {
                foreach (var row in dt.Rows.Cast<DataRow>())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        var val = row.ItemArray[colMapping[prop.Name.ToLower()].Ordinal];
                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }

                    objList.Add(obj);
                }
            }

            return objList;
        }
    }
}
