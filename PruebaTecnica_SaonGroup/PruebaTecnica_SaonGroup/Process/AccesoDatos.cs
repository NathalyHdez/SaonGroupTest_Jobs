using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;

namespace PruebaTecnica_SaonGroup.Process
{
    public class AccesoDatos
    {
        public List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            PropertyInfo[] pi;

            foreach (DataColumn column in dr.Table.Columns)
            {
                
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    //if (dr[column.ColumnName] == DBNull.Value)
                    //       dr[column.ColumnName] = DBNull.Value;

                    object value = dr[column.ColumnName];
                    if (value == DBNull.Value)
                        value = null;

                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, value, null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}