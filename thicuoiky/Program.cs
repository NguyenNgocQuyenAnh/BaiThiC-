using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thicuoiky
{
    class Luu
    {
        static bool kt = true;
        public static bool KT
        {
            get { return kt; }
            set { kt = value; }
        }
        public static DataTable CreateDataTable<T>(IList<T> item)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in item)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }
            dataTable.Columns.Add("tt");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["tt"] = (i + 1).ToString();
            }
            return dataTable;
        }

    }
        static class Program
    {   

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmChinh());
        }
    }
}
