using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS.Common.Extensions
{
    public static class CollectionExtension
    {
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            if (data != null)
            {
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            table.AcceptChanges();
            return table;
        }
        public static bool IsModified(this DataTable dt)
        {
            try
            {
                if (dt != null)
                {
                    bool isAdded = dt.GetChanges(DataRowState.Added) != null;
                    bool isDeleted = dt.GetChanges(DataRowState.Deleted) != null;
                    bool isModified = dt.GetChanges(DataRowState.Modified) != null;
                    return isAdded || isDeleted || isModified;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ExecuteQuery(this SqlCommand command)
        {
            try
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    var tb = new DataTable();
                    tb.Load(dr);
                    return tb;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetValue(this DataRow dr, string ColName, object value)
        {
            try
            {
                if (dr != null)
                {
                    if (value != null)
                    {
                        dr[ColName] = value;
                    }
                    else
                    {
                        dr[ColName] = DBNull.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void SetValue(this DataGridViewCell cell, object value)
        {
            try
            {
                if (cell != null)
                {
                    if (value != null)
                    {
                        cell.Value = value;
                    }
                    else
                    {
                        DataRow dr = ((DataRowView)cell.OwningRow.DataBoundItem).Row;
                        if (dr != null)
                        {
                            string colName = cell.OwningColumn.DataPropertyName;
                            dr[colName] = DBNull.Value;
                        }
                        else
                        {
                            cell.Value = DBNull.Value;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
