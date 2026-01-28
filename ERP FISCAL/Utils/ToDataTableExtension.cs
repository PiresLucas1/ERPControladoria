using System;
using System.Collections.Generic;
using System.Data;

namespace ERP_FISCAL.Utils
{
    public static class ToDataTableExtension
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            var table = new DataTable();
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                table.Columns.Add(
                    prop.Name,
                    Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType
                    );
            }
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (var prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
