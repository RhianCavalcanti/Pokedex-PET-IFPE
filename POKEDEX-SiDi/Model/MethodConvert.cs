using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;


namespace POKEDEX_SiDi.Model
{
    public static class MethodConvert
    {
        public static List<T> ToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach(var prop in obj.GetType().GetProperty())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
                return list;

            }
            catch
            {
                return null;
            }
            
        }
        
    }
}
